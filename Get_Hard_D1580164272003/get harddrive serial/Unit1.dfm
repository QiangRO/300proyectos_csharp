object Serialfrm: TSerialfrm
  Left = 361
  Top = 215
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'Hard Drive Serial Finder:'
  ClientHeight = 54
  ClientWidth = 227
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object SerialBox1: TGroupBox
    Left = 0
    Top = 0
    Width = 227
    Height = 54
    Align = alClient
    Caption = 'C:\ Serial Number'
    TabOrder = 0
    object SerialTxt: TEdit
      Left = 12
      Top = 20
      Width = 201
      Height = 21
      TabOrder = 0
    end
  end
end
