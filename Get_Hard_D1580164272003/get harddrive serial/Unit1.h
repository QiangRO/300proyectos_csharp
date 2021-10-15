//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <FileCtrl.hpp>
//---------------------------------------------------------------------------
class TSerialfrm : public TForm
{
__published:	// IDE-managed Components
        TGroupBox *SerialBox1;
        TEdit *SerialTxt;
        void __fastcall FormCreate(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TSerialfrm(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TSerialfrm *Serialfrm;
//---------------------------------------------------------------------------
#endif
