unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Menus, StdCtrls;

type
  TForm2 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    procedure N1Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

uses Unit1, Unit4, Unit3, Unit5, Unit6;

{$R *.dfm}

procedure TForm2.N1Click(Sender: TObject);
begin
Close;
end;

procedure TForm2.Button1Click(Sender: TObject);
begin
Form1.showmodal;
end;

procedure TForm2.Button3Click(Sender: TObject);
begin
Form4.showmodal;
end;

procedure TForm2.Button2Click(Sender: TObject);
begin
Form3.showmodal;
end;

procedure TForm2.Button4Click(Sender: TObject);
begin
Form5.showmodal;
end;

procedure TForm2.Button5Click(Sender: TObject);
begin
Form6.showmodal;
end;

end.
