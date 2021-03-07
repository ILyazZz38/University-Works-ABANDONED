unit Unit3;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TFPassword }

  TFPassword = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Label1: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormKeyDown(Sender: TObject; var Key: Word; Shift: TShiftState);
  private

  public

  end;

var
  FPassword: TFPassword;

implementation
Uses Unit1;

{$R *.lfm}

{ TFPassword }

procedure TFPassword.Button1Click(Sender: TObject);
begin
  if Edit1.Text = 'пароль' then begin
  Form1.Show;
  Close;
  end else
  ShowMessage('Пароль неверный. Правильный пароль:"Пароль"');
end;

procedure TFPassword.Button2Click(Sender: TObject);
begin
  Application.Terminate;
end;

procedure TFPassword.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
//  if (Key = vk_F4) and(ssAlt in Shift) then Application.Terminate;
end;

end.

