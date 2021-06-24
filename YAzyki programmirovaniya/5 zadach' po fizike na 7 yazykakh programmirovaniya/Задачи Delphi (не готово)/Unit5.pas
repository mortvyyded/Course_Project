unit Unit5;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls;

type
  TForm5 = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Image1: TImage;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form5: TForm5;

implementation

{$R *.dfm}

procedure TForm5.Button1Click(Sender: TObject);

 var  A,I,R,t:Real;
begin
I:=StrToFloat(Edit2.Text);
A:=StrToFloat(Edit3.Text);
t:=StrToFloat(Edit4.Text);
R:= A*exp(3*ln(10))/(exp(2*ln(I))*t);
Edit1.Text:=FloatToStr(R);
end;

end.
