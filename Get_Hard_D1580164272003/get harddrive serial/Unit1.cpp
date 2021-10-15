//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TSerialfrm *Serialfrm;
//---------------------------------------------------------------------------
__fastcall TSerialfrm::TSerialfrm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------


void __fastcall TSerialfrm::FormCreate(TObject *Sender)
{
DWORD VolumeSerialNumber;
LPDWORD MaxComponetLength, FileFlag;
GetVolumeInformation("c:\\",NULL,0,&VolumeSerialNumber,MaxComponetLength,FileFlag,NULL,0);
SerialTxt->Text = VolumeSerialNumber;        
}
//---------------------------------------------------------------------------
