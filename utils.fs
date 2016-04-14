\ (c)copyright 2014 by Gerald Wodni
\ partly taken from mecrisp examples by Mathias Koch

: MOTD ." Welcome back, commander!" ;

: init
  decimal
  cr MOTD cr ;

\ missing Forth 200x words

: invert  not  inline 1-foldable ;


\ helpers

: bounds over + swap ;

: limits ( n1 n-min n-max -- n2 )
	rot min max ;

: cornerstone ( Name ) ( -- )
  <builds begin here $3FF and while 0 h, repeat
  does>   begin dup  $3FF and while 2+   repeat 
          eraseflashfrom
;

: key-flush ( -- )
	begin key? while key drop repeat ;

