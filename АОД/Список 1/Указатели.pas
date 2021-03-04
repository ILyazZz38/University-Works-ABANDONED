var n:integer;
p: ^integer;



begin
  n:=5;//p указывает на значение n
  p:=@n;
  writeln(p^);
  
  
  p^:=6;//p меняет значение указанной переменной
  writeln(n);
  
  
  
  p:=nil;//p ни на что не указывает
  new(p);//p указывает на несуществующую переменную
  p^:=1;
  writeln(p^);
  dispose(p);
  readln;
end.