class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
    int n = morseCode.Length;
    
    if (morseCode[0] == ' ') {
      morseCode.Remove(0, 1);
      if (morseCode[n-1] == ' ')
        morseCode.Remove(n-1);
    } else if (morseCode[n-1] == ' ') {
      morseCode.Remove(n-1);
    }
    
    n = morseCode.Length;
    
    string translated = "";
    string morse = ""; 
    int count = 0;
    
    for (int i=0; i < morseCode.Length; i++) {
      while (morseCode[i] != ' ') {
        morse += morseCode[i];
      }
      
      switch (morse) {
          case ".-":
            translated += "A";
            break;
          case "-...":
            translated += "B";
            break;
          case "-.-.":
            translated += "C";
            break;
          case "-..":
            translated += "D";
            break;
          case ".":
            translated += "E";
            break;
          case "..-.":
            translated += "F";
            break;
          case "--.":
            translated += "G";
            break;
          case "....":
            translated += "H";
            break;
          case "..":
            translated += "I";
            break;
          case ".---":
            translated += "J";
            break;
          case "-.-":
            translated += "K";
            break;
          case ".-..":
            translated += "L";
            break;
          case "--":
            translated += "M";
            break;
          case "-.":
            translated += "N";
            break;
          case "---":
            translated += "O";
            break;
          case ".--.":
            translated += "P";
            break;
          case "--.-":
            translated += "Q";
            break;
          case ".-.":
            translated += "R";
            break;
          case "...":
            translated += "S";
            break;
          case "-":
            translated += "T";
            break;
          case "..-":
            translated += "U";
            break;
          case "...-":
            translated += "V";
            break;
          case ".--":
            translated += "W";
            break;
          case "-..-":
            translated += "X";
            break;
          case "-.--":
            translated += "Y";
            break;
          case "--..":
            translated += "Z";
            break;
          default:
            continue;
      }
      
      if (morseCode[i] == ' ') {
        count++;
        if (count == 3) {
          translated += " ";
          count = 0;
        }
      }
    }
    
		return translated;
	}
}