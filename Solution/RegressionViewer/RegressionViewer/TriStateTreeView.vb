Imports System.Runtime.InteropServices

Namespace TriStateTreeView
    Public Enum CheckBoxState
        None = 0
        Unchecked = 1
        Checked = 2
        Indeterminate = 3
    End Enum

    Public Class TriStateTreeView
        Inherits System.Windows.Forms.TreeView

        <StructLayout(LayoutKind.Sequential)> _
        Private Structure TVITEM
            Public mask As Integer
            Public hItem As IntPtr
            Public state As Integer
            Public stateMask As Integer
            Public pszText As Integer
            Public cchTextMax As Integer
            Public iImage As Integer
            Public iSelectedImage As Integer
            Public cChildren As Integer
            Public lParam As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Private Structure POINTAPI
            Public x As Integer
            Public y As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Private Structure TVHITTESTINFO
            Public pt As POINTAPI
            Public flags As Integer
            Public hItem As IntPtr
        End Structure

        ' Messages
        Private Const TV_FIRST As Integer = &H1100
        Private Const TVM_SETIMAGELIST As Integer = TV_FIRST + 9
        Private Const TVM_GETITEM As Integer = TV_FIRST + 12
        Private Const TVM_SETITEM As Integer = TV_FIRST + 13
        Private Const TVM_HITTEST As Integer = TV_FIRST + 17

        ' TVM_SETIMAGELIST image list kind
        Private Const TVSIL_STATE As Integer = 2

        'TVITEM.mask flags
        Private Const TVIF_STATE As Integer = &H8
        Private Const TVIF_HANDLE As Integer = &H10

        'TVITEM.state flags
        Public Const TVIS_STATEIMAGEMASK As Integer = &HF000

        'TVHITTESTINFO.flags flags
        Public Const TVHT_ONITEMSTATEICON As Integer = &H40

        ' ImageList Images Indexes
        Private Const m_IMG_CHECKBOX_NONE As Integer = 0
        Private Const m_IMG_CHECKBOX_UNCHECKED As Integer = 1
        Private Const m_IMG_CHECKBOX_CHECKED As Integer = 2
        Private Const m_IMG_CHECKBOX_INDETERMINATE As Integer = 3

        Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
        Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As TVITEM) As Integer
        Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As TVHITTESTINFO) As Integer

        Public Sub SetImagesList(ByVal ctlStateImageList As ImageList)

            Dim iResult As Integer

            ' Set the state image list
            iResult = SendMessage(Me.Handle, TVM_SETIMAGELIST, TVSIL_STATE, ctlStateImageList.Handle)

        End Sub
        Public Function FindByTag(ByVal tag As Object) As TreeNode
            Dim myEnumerator As IEnumerator
            myEnumerator = Me.Nodes.GetEnumerator()
            While (myEnumerator.MoveNext())
                Dim tn As TreeNode
                tn = CType(myEnumerator.Current, TreeNode)
                If (tn.Tag Is tag) Then Return tn
            End While
            Dim tn1 As TreeNode
            Return tn1
        End Function

        Public Sub New()


        End Sub

        Private Sub SetTreeNodeAndChildrenStateRecursively(ByVal objTreeNode As TreeNode, ByVal eCheckBoxState As CheckBoxState)

            Dim objChildTreeNode As TreeNode

            If Not (objTreeNode Is Nothing) Then

                SetTreeNodeState(objTreeNode, eCheckBoxState)

                For Each objChildTreeNode In objTreeNode.Nodes
                    SetTreeNodeAndChildrenStateRecursively(objChildTreeNode, eCheckBoxState)
                Next

            End If

        End Sub

        Private Sub SetParentTreeNodeStateRecursively(ByVal objParentTreeNode As TreeNode)

            Dim objTreeNode As TreeNode
            Dim eCheckBoxState As CheckBoxState
            Dim bAllChildrenChecked As Boolean = True
            Dim bAllChildrenUnchecked As Boolean = True


            If Not (objParentTreeNode Is Nothing) Then

                If GetTreeNodeState(objParentTreeNode) <> CheckBoxState.None Then

                    For Each objTreeNode In objParentTreeNode.Nodes

                        eCheckBoxState = GetTreeNodeState(objTreeNode)

                        Select Case eCheckBoxState

                            Case CheckBoxState.Checked
                                bAllChildrenUnchecked = False

                            Case CheckBoxState.Indeterminate
                                bAllChildrenUnchecked = False
                                bAllChildrenChecked = False

                            Case CheckBoxState.Unchecked
                                bAllChildrenChecked = False

                        End Select

                        If bAllChildrenChecked = False And bAllChildrenUnchecked = False Then
                            ' This is an optimization
                            Exit For
                        End If

                    Next

                    If bAllChildrenChecked Then
                        SetTreeNodeState(objParentTreeNode, CheckBoxState.Checked)
                    ElseIf bAllChildrenUnchecked Then
                        SetTreeNodeState(objParentTreeNode, CheckBoxState.Unchecked)
                    Else
                        SetTreeNodeState(objParentTreeNode, CheckBoxState.Indeterminate)
                    End If

                    ' Enter in recursion
                    If Not (objParentTreeNode.Parent Is Nothing) Then
                        SetParentTreeNodeStateRecursively(objParentTreeNode.Parent)
                    End If

                End If

            End If

        End Sub

        Public Function GetTreeNodeState(ByVal objTreeNode As TreeNode) As CheckBoxState

            Dim eCheckBoxState As CheckBoxState = CheckBoxState.Unchecked


            Dim tTVITEM As TVITEM
            Dim iState As Integer
            Dim iResult As Integer

            tTVITEM.mask = TVIF_HANDLE Or TVIF_STATE
            tTVITEM.hItem = objTreeNode.Handle
            tTVITEM.stateMask = TVIS_STATEIMAGEMASK
            tTVITEM.state = 0

            iResult = SendMessage(Me.Handle, TVM_GETITEM, 0, tTVITEM)

            If iResult <> 0 Then

                iState = tTVITEM.state

                ' State image index in bits 12..15
                iState = iState \ &HFFF

                Select Case iState

                    Case m_IMG_CHECKBOX_NONE
                        eCheckBoxState = CheckBoxState.None

                    Case m_IMG_CHECKBOX_UNCHECKED
                        eCheckBoxState = CheckBoxState.Unchecked

                    Case m_IMG_CHECKBOX_CHECKED
                        eCheckBoxState = CheckBoxState.Checked

                    Case m_IMG_CHECKBOX_INDETERMINATE
                        eCheckBoxState = CheckBoxState.Indeterminate

                End Select

            End If

            Return eCheckBoxState

        End Function

        Public Sub SetTreeNodeState(ByVal objTreeNode As TreeNode, ByVal eCheckBoxState As CheckBoxState)

            Dim iImageIndex As Integer
            Dim tTVITEM As TVITEM
            Dim iState As Integer
            Dim iResult As Integer

            If Not (objTreeNode Is Nothing) Then

                Select Case eCheckBoxState

                    Case CheckBoxState.None
                        iImageIndex = m_IMG_CHECKBOX_NONE

                    Case CheckBoxState.Unchecked
                        iImageIndex = m_IMG_CHECKBOX_UNCHECKED

                    Case CheckBoxState.Checked
                        iImageIndex = m_IMG_CHECKBOX_CHECKED

                    Case CheckBoxState.Indeterminate
                        iImageIndex = m_IMG_CHECKBOX_INDETERMINATE

                End Select

                tTVITEM.mask = TVIF_HANDLE Or TVIF_STATE
                tTVITEM.hItem = objTreeNode.Handle
                tTVITEM.stateMask = TVIS_STATEIMAGEMASK
                ' State image index in bits 12..15
                tTVITEM.state = iImageIndex * &H1000

                iResult = SendMessage(Me.Handle, TVM_SETITEM, 0, tTVITEM)

            End If

        End Sub

        Private Sub ToggleTreeNodeState(ByVal objTreeNode As TreeNode)

            Dim eCheckBoxState As CheckBoxState

            eCheckBoxState = GetTreeNodeState(objTreeNode)

            Me.BeginUpdate()

            Select Case eCheckBoxState

                Case CheckBoxState.Unchecked

                    SetTreeNodeAndChildrenStateRecursively(objTreeNode, CheckBoxState.Checked)
                    SetParentTreeNodeStateRecursively(objTreeNode.Parent)

                Case CheckBoxState.Checked, CheckBoxState.Indeterminate

                    SetTreeNodeAndChildrenStateRecursively(objTreeNode, CheckBoxState.Unchecked)
                    SetParentTreeNodeStateRecursively(objTreeNode.Parent)

            End Select

            Me.EndUpdate()

        End Sub

        Private Function GetTreeNodeHitAtCheckBoxByScreenPosition(ByVal iXScreenPos As Integer, ByVal iYScreenPos As Integer) As TreeNode

            Dim objClientPoint As Point
            Dim objTreeNode As TreeNode

            objClientPoint = Me.PointToClient(New Point(iXScreenPos, iYScreenPos))

            objTreeNode = GetTreeNodeHitAtCheckBoxByClientPosition(objClientPoint.X, objClientPoint.Y)

            Return objTreeNode

        End Function

        Private Function GetTreeNodeHitAtCheckBoxByClientPosition(ByVal iXClientPos As Integer, ByVal iYClientPos As Integer) As TreeNode

            Dim objTreeNode As TreeNode
            Dim iTreeNodeHandle As Integer
            Dim tTVHITTESTINFO As TVHITTESTINFO

            ' Get the hit info
            tTVHITTESTINFO.pt.x = iXClientPos
            tTVHITTESTINFO.pt.y = iYClientPos
            iTreeNodeHandle = SendMessage(Me.Handle, TVM_HITTEST, 0, tTVHITTESTINFO)

            ' Check if it has clicked on an item
            If iTreeNodeHandle <> 0 Then

                ' Check if it has clicked on the state image of the item
                If (tTVHITTESTINFO.flags And TVHT_ONITEMSTATEICON) <> 0 Then

                    objTreeNode = TreeNode.FromHandle(Me, New IntPtr(iTreeNodeHandle))

                End If

            End If

            Return objTreeNode

        End Function

        Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)

            Dim objTreeNode As TreeNode

            MyBase.OnMouseUp(e)

            objTreeNode = GetTreeNodeHitAtCheckBoxByClientPosition(e.X, e.Y)
            If Not (objTreeNode Is Nothing) Then

                ToggleTreeNodeState(objTreeNode)

            End If

        End Sub

        Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)

            MyBase.OnKeyUp(e)

            If e.KeyCode = Keys.Space Then

                If Not (Me.SelectedNode Is Nothing) Then
                    ToggleTreeNodeState(Me.SelectedNode)
                End If

            End If

        End Sub

        Protected Overrides Sub OnBeforeExpand(ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)

            ' PATCH: if the node is being expanded by a double click at the state image, cancel it
            If Not (GetTreeNodeHitAtCheckBoxByScreenPosition(Control.MousePosition.X, Control.MousePosition.Y) Is Nothing) Then
                e.Cancel = True
            End If

        End Sub

        Protected Overrides Sub OnBeforeCollapse(ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)

            ' PATCH: if the node is being collapsed by a double click at the state image, cancel it
            If Not (GetTreeNodeHitAtCheckBoxByScreenPosition(Control.MousePosition.X, Control.MousePosition.Y) Is Nothing) Then
                e.Cancel = True
            End If

        End Sub

        Public Function AddTreeNode(ByVal colNodes As TreeNodeCollection, ByVal sNodeText As String, ByVal iImageIndex As Integer, ByVal eCheckBoxState As CheckBoxState) As TreeNode

            Dim objTreeNode As TreeNode

            objTreeNode = New TreeNode(sNodeText)

            objTreeNode.ImageIndex = iImageIndex
            objTreeNode.SelectedImageIndex = iImageIndex

            colNodes.Add(objTreeNode)

            Me.SetTreeNodeState(objTreeNode, eCheckBoxState)

            Return objTreeNode

        End Function


    End Class

End Namespace