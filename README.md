#bitclock
(c) 2016 by Gerald Wodni and Erich Waelde

WS2812B strip arranged in a circle of 50 leds to represent a clock driven Forth

uses a Ti Tiva LaunchPad (TM4C123GXL)

### Wiring
|  µC  | WS2812B Strip |
|------|---------------|
| VBUS | +5V           |
| GND  | GNX           |
| PB7  | DIN           |

If you supply the strip directly over the LaunchPad, don't use more than 4 LEDS at maximum intensity at once!
You might also want to add a 200µF capacitor between VBUS and GND to ensure stability.
