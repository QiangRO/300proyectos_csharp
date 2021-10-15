Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace MyProject

    Public Class RadioButton
        Inherits Windows.Forms.RadioButton

        Dim m_hover As Boolean = False

        Public Sub New()
            Me.Appearance = Appearance.Button
        End Sub

        Protected Overrides Sub OnPaint(ByVal pevent As System.Windows.Forms.PaintEventArgs)

            If (Me.Checked) Then
                Using lgb As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(200, 220, 250), Color.FromArgb(180, 200, 240), LinearGradientMode.Vertical)
                    pevent.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                End Using
                Using p As New Pen(Color.FromArgb(0, 0, 0), 1)
                    Dim r As New Rectangle(0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
                    pevent.Graphics.DrawRectangle(p, r)
                End Using
            Else
                If (m_hover) Then
                    Using lgb As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(223, 236, 250), Color.FromArgb(178, 214, 252), LinearGradientMode.BackwardDiagonal)
                        pevent.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                    End Using
                    Using p As New Pen(Color.FromArgb(0, 0, 255))
                        Dim r As New Rectangle(0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
                        pevent.Graphics.DrawRectangle(p, r)
                    End Using
                Else
                    Using lgb As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(221, 220, 220), Color.FromArgb(244, 243, 243), LinearGradientMode.Vertical)
                        pevent.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                    End Using
                    Using p As New Pen(Color.FromArgb(150, 150, 150))
                        Dim r As New Rectangle(0, 0, Me.ClientRectangle.Width - 1, Me.ClientRectangle.Height - 1)
                        pevent.Graphics.DrawRectangle(p, r)
                    End Using
                    'pevent.Graphics.Clear(Me.BackColor)
                End If

            End If

            

            'Center image
            Dim x As Integer = (Me.ClientRectangle.Width - Me.Image.Width) / 2
            Dim y As Integer = (Me.ClientRectangle.Height - Me.Image.Height) / 2

            pevent.Graphics.DrawImage(Me.Image, New Rectangle(x, y, Me.Image.Width, Me.Image.Height), New Rectangle(0, 0, Me.Image.Width, Me.Image.Height), GraphicsUnit.Pixel)
        End Sub


        Protected Overrides Sub OnMouseEnter(ByVal eventargs As System.EventArgs)
            MyBase.OnMouseEnter(eventargs)
            m_hover = True
            'My.Computer.Audio.Play(My.Resources.BtnHover, AudioPlayMode.Background)

            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal eventargs As System.EventArgs)
            MyBase.OnMouseLeave(eventargs)

            m_hover = False

            Me.Invalidate()
        End Sub

    End Class

End Namespace
