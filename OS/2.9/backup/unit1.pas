unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, ExtCtrls, StdCtrls,
  Grids, Types;

type

  { TFonts }

  TFonts = class(TForm)
    FontDG: TDrawGrid;
    FontCB: TComboBox;
    Panel1: TPanel;
    procedure FontCBClick(Sender: TObject);
    procedure FontDGDrawCell(Sender: TObject; aCol, aRow: Integer;
      aRect: TRect; aState: TGridDrawState);
    procedure FormCreate(Sender: TObject);
  private

  public

  end;

var
  Fonts: TFonts;

implementation

{$R *.lfm}

{ TFonts }



procedure TFonts.FontDGDrawCell(Sender: TObject; aCol, aRow: Integer;
  aRect: TRect; aState: TGridDrawState);
begin
  with FontDG.Canvas do
TextRect(aRect, aRect.Left, aRect.Top, Char((aRow+1)*32+ACol));
end;

procedure TFonts.FontCBClick(Sender: TObject);
begin
  FontDG.Font.Name:=FontCB.Text;
end;

procedure TFonts.FormCreate(Sender: TObject);
begin
  with FontCB do
begin
  Items:=Screen.Fonts;
  ItemIndex:=Items.IndexOf(Font.Name);
  end;
end;

end.

