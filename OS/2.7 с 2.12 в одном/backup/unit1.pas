unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, StdCtrls, LCLType;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Edit1Change(Sender: TObject);
    procedure Edit1UTF8KeyPress(Sender: TObject; var UTF8Key: TUTF8Char);
    procedure Edit2Change(Sender: TObject);
    procedure Edit3Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure Label1Click(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;
  a,b,c,x1,x2,d:real;


implementation
Uses Unit2, Unit3;

{$R *.lfm}

{ TForm1 }

procedure TForm1.Label1Click(Sender: TObject);
begin

end;

procedure TForm1.FormCreate(Sender: TObject);
begin

end;

procedure TForm1.FormShow(Sender: TObject);
begin
  FPassword.ShowModal;
end;

procedure TForm1.Edit1Change(Sender: TObject);
begin

end;

procedure TForm1.Edit1UTF8KeyPress(Sender: TObject; var UTF8Key: TUTF8Char);
begin
  case UTF8Key of //Разрешенные символы
  '0'..'9','-',#8: ;
  else
    UTF8Key:=#0;
  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  if (Edit1.Text = '0') or (Edit2.Text = '0') then begin
    ShowMessage('A and B <> 0!');
  end else begin
    a:= StrToInt(Edit1.Text);
    b:= StrToInt(Edit2.Text);
    c:= StrToInt(Edit3.Text);
    d:=(b*b)-(4*a*c);
    if d < 0 then begin
    ShowMessage('D > 0!');
    end else begin
    x1:=(sqrt(d) + b)/(2*a);
    x2:=(sqrt(d) - b)/(2*a);
    Edit4.Text:=FloatToStr(x1);
    Edit5.Text:=FloatToStr(x2);
    end;
  end;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  Close;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  FAbout.ShowModal;
end;

procedure TForm1.Edit2Change(Sender: TObject);
begin

end;

procedure TForm1.Edit3Change(Sender: TObject);
begin

end;

end.

