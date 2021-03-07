unit Unit2;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, ExtCtrls, StdCtrls;

type

  { TFAbout }

  TFAbout = class(TForm)
    Button1: TButton;
    Image2: TImage;
    Label1: TLabel;
    Label3: TLabel;
    Label5: TLabel;
    Timer1: TTimer;
    procedure Button1Click(Sender: TObject);

    procedure FormCreate(Sender: TObject);
    procedure FormKeyDown(Sender: TObject; var Key: Word; Shift: TShiftState);

    procedure Timer1Timer(Sender: TObject);
  private

  public

  end;

var
  FAbout: TFAbout;

implementation

{$R *.lfm}

{ TFAbout }

procedure TFAbout.Button1Click(Sender: TObject);
begin
  Close;
end;


procedure TFAbout.FormCreate(Sender: TObject);
begin

end;

procedure TFAbout.FormKeyDown(Sender: TObject; var Key: Word; Shift: TShiftState
  );
begin
  ShowMessage('Закрыто');
  close;
end;


procedure TFAbout.Timer1Timer(Sender: TObject);
begin
   close;
end;


end.

