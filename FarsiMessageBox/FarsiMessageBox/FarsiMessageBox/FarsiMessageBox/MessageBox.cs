using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FarsiMessageBox
{
    public class MessageBox
    {
        public enum Icons { Error, Warning, Information, Question };
        public enum Buttons { OK, OKCancel, RetryCancel, YesNo, YesNoCancel };
        // --------------------------------------------------------------------------
        public static DialogResult Show(string title, string text, Buttons buttons, Icons icon)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.label.Text = text;
            if (icon == Icons.Error)
                msgBox.icon.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("FarsiMessageBox.Icons.error.bmp"));
            else if (icon == Icons.Information)
                msgBox.icon.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("FarsiMessageBox.Icons.info.bmp"));
            else if (icon == Icons.Question)
                msgBox.icon.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("FarsiMessageBox.Icons.question.bmp"));
            else if (icon == Icons.Warning)
                msgBox.icon.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("FarsiMessageBox.Icons.warning.bmp"));
            if (buttons == Buttons.OK)
            {
                msgBox.OKPanel.Left = 12;
                msgBox.OKPanel.Top = 53;
                msgBox.OKPanel.BringToFront();
                if (icon == Icons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == Icons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == Icons.Question)
                    SystemSounds.Question.Play();
                else if (icon == Icons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == Buttons.OKCancel)
            {
                msgBox.OKCancelPanel.Left = 12;
                msgBox.OKCancelPanel.Top = 53;
                msgBox.OKCancelPanel.BringToFront();
                if (icon == Icons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == Icons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == Icons.Question)
                    SystemSounds.Question.Play();
                else if (icon == Icons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == Buttons.RetryCancel)
            {
                msgBox.RetryCancelPanel.Left = 12;
                msgBox.RetryCancelPanel.Top = 53;
                msgBox.RetryCancelPanel.BringToFront();
                if (icon == Icons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == Icons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == Icons.Question)
                    SystemSounds.Question.Play();
                else if (icon == Icons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == Buttons.YesNo)
            {
                msgBox.YesNoPanel.Left = 12;
                msgBox.YesNoPanel.Top = 53;
                msgBox.YesNoPanel.BringToFront();
                if (icon == Icons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == Icons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == Icons.Question)
                    SystemSounds.Question.Play();
                else if (icon == Icons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == Buttons.YesNoCancel)
            {
                msgBox.YesNoCancelPanel.Left = 12;
                msgBox.YesNoCancelPanel.Top = 53;
                msgBox.YesNoCancelPanel.BringToFront();
                if (icon == Icons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == Icons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == Icons.Question)
                    SystemSounds.Question.Play();
                else if (icon == Icons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            return msgBox.Result;
        }
    }
}
