ORG 00H
JMP MAIN
ORG 03H
JMP INTERRUPT0
RETI
ORG 13H
JMP INTERRUPT1
RETI
ORG 30H
MAIN:
      MOV IE,#85H
      SETB TCON.0
      SETB TCON.2
        MOV DPTR,#CODE3
        MOV A,38H
        CALL COMAND 
        MOV A,#0EH
        CALL COMAND
        MOV A,#01H
        CALL COMAND
        MOV R0,#16
        L1:
          CLR A
          MOVC A,@A+DPTR
          CALL DISPLAY
          INC DPTR
        DJNZ R0,L1
HERE: SJMP HERE        
INTERRUPT0:
      MOV DPTR,#CODE1
        MOV A,38H
        CALL COMAND 
        MOV A,#0EH
        CALL COMAND
        MOV A,#01H
        CALL COMAND
        MOV R0,#16
        L2:
          CLR A
          MOVC A,@A+DPTR
          CALL DISPLAY
          INC DPTR
        DJNZ R0,L2
      RETI
INTERRUPT1:
      MOV DPTR,#CODE2
        MOV A,38H
        CALL COMAND 
        MOV A,#0EH
        CALL COMAND
        MOV A,#01H
        CALL COMAND
        MOV R0,#16
        L3:
          CLR A
          MOVC A,@A+DPTR
          CALL DISPLAY
          INC DPTR
        DJNZ R0,L3
RETI      
COMAND:
      CALL STATUSE
      MOV P1,A
      CLR P2.0
      CLR P2.1
      SETB P2.2
      CLR P2.2
      RET
DISPLAY:
      CALL STATUSE
      MOV P1,A
      SETB P2.0
      CLR P2.1
      SETB P2.2
      CLR P2.2
      RET
STATUSE:
      SETB P1.7
      CLR P2.0
      SETB P2.1
      BACK:
          CLR P2.2
          SETB P2.2
          JB P1.7,BACK
          RET
ORG 500H
  CODE1: DB "Beytollah             "
  CODE2: DB "Mozaffari           "
  CODE3: DB "   Well Come"
END  
;------------------------------------------------------------------------------------
;END OF PROGRAM             
