unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, ComCtrls, StdCtrls,
  Menus, Buttons, ExtCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    ColorDialog1: TColorDialog;
    ComboBox1: TComboBox;
    FontDialog1: TFontDialog;
    MainMenu1: TMainMenu;
    Memo1: TMemo;
    MenuItem1: TMenuItem;
    MenuItem10: TMenuItem;
    MenuItem11: TMenuItem;
    MenuItem12: TMenuItem;
    MenuItem2: TMenuItem;
    MenuItem3: TMenuItem;
    MenuItem4: TMenuItem;
    MenuItem5: TMenuItem;
    MenuItem6: TMenuItem;
    MenuItem7: TMenuItem;
    MenuItem8: TMenuItem;
    MenuItem9: TMenuItem;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    SpeedButton5: TSpeedButton;
    SpeedButton6: TSpeedButton;
    SpeedButton7: TSpeedButton;
    SpeedButton8: TSpeedButton;
    Splitter1: TSplitter;
    Splitter2: TSplitter;
    Splitter3: TSplitter;
    ToolBar1: TToolBar;

    procedure ComboBox1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure MenuItem10Click(Sender: TObject);
    procedure MenuItem11Click(Sender: TObject);
    procedure MenuItem12Click(Sender: TObject);
    procedure MenuItem2Click(Sender: TObject);
    procedure MenuItem3Click(Sender: TObject);
    procedure MenuItem4Click(Sender: TObject);
    procedure MenuItem5Click(Sender: TObject);
    procedure MenuItem8Click(Sender: TObject);
    procedure MenuItem9Click(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
    procedure SpeedButton5Click(Sender: TObject);
    procedure SpeedButton6Click(Sender: TObject);
    procedure SpeedButton7Click(Sender: TObject);
    procedure SpeedButton8Click(Sender: TObject);
    procedure ToolBar1Click(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.MenuItem3Click(Sender: TObject);
begin
  Memo1.Lines.Clear;
end;

procedure TForm1.MenuItem2Click(Sender: TObject);
begin
  close;
end;

procedure TForm1.MenuItem11Click(Sender: TObject);
begin
  if FontDialog1.Execute then
  Memo1.Font:=FontDialog1.Font;
end;

procedure TForm1.MenuItem10Click(Sender: TObject);
begin
  Memo1.PasteFromClipboard;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin

  ComboBox1.Items:=Screen.Fonts;
end;

procedure TForm1.ComboBox1Click(Sender: TObject);
begin
  Memo1.Font.Name:=ComboBox1.Items.
end;



procedure TForm1.MenuItem12Click(Sender: TObject);
begin
  if ColorDialog1.Execute then
  Memo1.Font.Color:=ColorDialog1.Color;
end;

procedure TForm1.MenuItem4Click(Sender: TObject);
begin
  Memo1.Lines.Clear;
  if OpenDialog1.Execute then
  Memo1.Lines.LoadFromFile(OpenDialog1.FileName);
end;

procedure TForm1.MenuItem5Click(Sender: TObject);
begin
  if SaveDialog1.Execute then
  Memo1.Lines.SaveToFile(SaveDialog1.FileName);
  Memo1.Lines.Clear;
end;

procedure TForm1.MenuItem8Click(Sender: TObject);
begin
  Memo1.CutToClipboard;
end;

procedure TForm1.MenuItem9Click(Sender: TObject);
begin
  Memo1.CopyToClipboard;
end;

procedure TForm1.SpeedButton1Click(Sender: TObject);
begin
  Memo1.Lines.Clear;
end;

procedure TForm1.SpeedButton2Click(Sender: TObject);
begin
  Memo1.Lines.Clear;
  if OpenDialog1.Execute then
  Memo1.Lines.LoadFromFile(OpenDialog1.FileName);
end;

procedure TForm1.SpeedButton3Click(Sender: TObject);
begin
  if SaveDialog1.Execute then
  Memo1.Lines.SaveToFile(SaveDialog1.FileName);
  Memo1.Lines.Clear;
end;

procedure TForm1.SpeedButton4Click(Sender: TObject);
begin
  Memo1.CutToClipboard;
end;

procedure TForm1.SpeedButton5Click(Sender: TObject);
begin
  Memo1.CopyToClipboard;
end;

procedure TForm1.SpeedButton6Click(Sender: TObject);
begin
  Memo1.PasteFromClipboard;
end;

procedure TForm1.SpeedButton7Click(Sender: TObject);
begin
  if FontDialog1.Execute then
  Memo1.Font:=FontDialog1.Font;
end;

procedure TForm1.SpeedButton8Click(Sender: TObject);
begin
  if ColorDialog1.Execute then
  Memo1.Font.Color:=ColorDialog1.Color;
end;

procedure TForm1.ToolBar1Click(Sender: TObject);
begin

end;

end.

