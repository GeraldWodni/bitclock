\ (c)copyright 2016 Gerald Wodni & Erich Waelde
cold


compiletoflash

: show ( n-hours n-minutes n-seconds -- )
       buffer-off 
       $1F0000 swap led-n-or!
       $001F00 swap led-n-or!
       $00001F swap led-n-or!
       flush ;

