algoritmo "campominado"
// Função : Jogo Campo Minado
// Autor :
// Data : 20/03/2023
// Seção de Declarações 
var
campo: vetor[1..4,1..4] de inteiro
i, j : inteiro
posi : inteiro
vito : inteiro
inicio
vito:=0
campo[1,1] := 0
campo[1,2]:=0
campo[1,3]:=0
campo[1,4]:=0
campo[2,1]:=0
campo[2,2]:=0
campo[2,3]:=0
campo[2,4]:=0
campo[3,1]:=0
campo[3,2]:=0
campo[3,3]:=0
campo[3,4]:=0
campo[4,1]:=0
campo[4,2]:=0
campo[4,3]:=0
campo[4,4]:=0

enquanto (vito<>12) faca
 para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreval ("Dê uma posição do campo")
 leia(posi)
 
 se(posi=11) entao
  campo[1,1] := 1
  vito:= vito + 1
 fimse
 se(posi=12) entao
  campo[1,2] := 5
  para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreva("você achou uma bomba, fim de jogo")
 fimalgoritmo
 fimse
 se(posi=13) entao
  campo[1,3] :=2
  vito:= vito + 1
 fimse
 se(posi=14) entao
  campo[1,4] := 5
  para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreva("você achou uma bomba, fim de jogo")
 fimalgoritmo
 fimse
  se(posi=21) entao
  campo[2,1] := 1
  vito:= vito + 1
 fimse
  se(posi=22) entao
  campo[2,2] := 2
  vito:= vito + 1
 fimse
  se(posi=23) entao
  campo[2,3] := 3
  vito:= vito + 1
 fimse
 se(posi=24) entao
  campo[2,4] := 2
  vito:= vito + 1
 fimse
 se(posi=31) entao
  campo[3,1] := 1
  vito:= vito + 1
 fimse
 se(posi=32) entao
  campo[3,2] := 2
  vito:= vito + 1
 fimse
 se(posi=33) entao
  campo[3,3] := 5
  para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreva("você achou uma bomba, fim de jogo")
 fimalgoritmo
 fimse
 se(posi=34) entao
  campo[3,4] := 1
  vito:= vito + 1
 fimse
 se(posi=41) entao
  campo[4,1] := 5
  para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreva("você achou uma bomba, fim de jogo")
 fimalgoritmo
 fimse
 se(posi=42) entao
  campo[4,2] := 2
  vito:= vito + 1
 fimse
 se(posi=43) entao
  campo[4,3] := 1
  vito:= vito + 1
 fimse
 se(posi=44) entao
  campo[4,4] := 1
  vito:= vito + 1
 fimse
fimenquanto
se(vito=12) entao
 para i de 1 ate 4 faca
  para j de 1 ate 4 faca
      escreva(campo[i,j])
   fimpara
   escreval
  fimpara
 escreva("Você evitou todas as bombas, venceu o jogo")
 fimse

 
 

 


fimalgoritmo
