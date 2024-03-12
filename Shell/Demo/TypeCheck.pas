program TypeCheck;
  const
  pi := 3.14;
  message := "Hello";
var 
  i, j, k, Fibo: integer;
  p, q, r, i: real;
function Fibo (fn: integer) : integer;
var
   fi: integer;
   j: real;
begin
   if fn <= 2 then Fibo := 1;
   else Fibo := Fibo (n - 2) + Fibo (n - 1);
   j := 3.5;
   Fibo (j);
end;
begin
  i := 1;
  p := 3.5;
  q := i + p;
  q := i + true;
  r := i;
  r := "Hello";
  Fibo (5, 4);
  Fibo (3.5);
  Fibo ('c');
  Fibo (c);
  Fibo (j);
end.