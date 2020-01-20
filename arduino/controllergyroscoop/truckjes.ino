void blinkDisco()
{
  int ledState = LOW;


  unsigned long previousMillis = 0;

  // constants won't change:
  const long interval = 10000;



  unsigned long currentMillis = millis();

 if (currentMillis - previousMillis >= interval) {
    // save the last time you blinked the LED
    previousMillis = currentMillis;

    // if the LED is off turn it on and vice-versa:
        previousMillis = currentMillis;


    int  redValue = random(256);
    int greenValue = random(256);
    int blueValue = random(256);
   
    
  
    // set the LED with the ledState of the variable:
    RGB_color(redValue, greenValue, blueValue);
  }
}
