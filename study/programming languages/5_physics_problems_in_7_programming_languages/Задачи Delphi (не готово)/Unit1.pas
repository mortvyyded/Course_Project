unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Buttons, ExtCtrls, jpeg;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Edit1: TEdit;
    Label2: TLabel;
    Edit2: TEdit;
    Label3: TLabel;
    Edit3: TEdit;
    Label4: TLabel;
    Edit4: TEdit;
    Image1: TImage;
    Button1: TButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.SpeedButton1Click(Sender: TObject);
 var
    q,I,R,t:Real;
begin
I:=StrToFloat(Edit2.Text);
R:=StrToFloat(Edit3.Text);
t:=StrToFloat(Edit4.Text);
q:=exp(I*ln(2))*(R*t);
Edit1.Text:=FloatToStr(q);
//floattostr((Edit2.Text)*strtofloat(Edit5.Text)*(strtofloat(Edit4.Text)-strtofloat(Edit3.Text)));

end;

procedure TForm1.Button1Click(Sender: TObject);

var
   q,I,R,t:Real;
begin
I:=StrToFloat(Edit2.Text);
R:=StrToFloat(Edit3.Text);
t:=StrToFloat(Edit4.Text);
q:=(exp(2*ln(I)))*(R*t);
Edit1.Text:=FloatToStr(q);
end;

end.
