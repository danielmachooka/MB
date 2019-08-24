using system;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;


int[] x = {213, 231, 250, 268, 285, 297, 310, 319, 324, 325, 326, 323, 315, 304, 291, 277, 260, 242, 223, 204, 183, 165, 147, 132, 120, 110, 102, 97, 98, 99, 104, 115, 126, 142, 158, 176, 194};
int[] y = {152, 153, 158, 165, 174, 185, 202, 219, 236, 254, 270, 293, 307, 322, 333, 348, 355, 361, 367, 364, 362, 357, 347, 338, 321, 307, 288, 269, 254, 234, 217, 201, 185, 174, 164, 160, 155};
string[] Number = { "0", "32", "15", "19", "4", "21", "2", "25", "17", "34", "6", "27", "13", "36", "11", "30", "8", "23", "10", "5", "24", "16", "33", "1", "20", "14", "31", "9", "22", "18", "29", "7", "28", "12", "35", "3", "26" };

string[] Red = { "32", "19", "21", "25", "34", "27", "36", "30", "23", "5", "16", "1", "14", "9", "18", "7", "12", "3" };
string[] Black = { "15", "4", "2", "17", "6", "13", "11", "8", "10", "24", "33", "20", "31", "22", "29", "28", "35", "26" };        

cboColour.Items.Add("Red");
cboColour.Items.Add("Black");

string guessColour = cboColour.Text;


if (position == ballPos && loopTimes == loopCount)             
{
    tmrRoll.Enabled = false;

    // Arrays (guessing)

    int arraypos = Array.IndexOf(Number, guess);

    int arrayRed = Array.IndexOf(Red, guessColour);
    int arrayBlack = Array.IndexOf(Black, guessColour);

    // Number + colour correct    
    if (ballPos == arraypos && ballPos == arrayBlack || ballPos == arraypos && ballPos == arrayRed)
    {
        MessageBox.Show("You guessed the number and the colour correctly!");
        addEarnings = currentBet * 35 + 10;
 totalGrapes = totalGrapes + addEarnings;              
    }
    // Only colour correct
    else if (ballPos != arraypos && ballPos == arrayBlack || ballPos != arraypos && ballPos == arrayRed)
    {
        MessageBox.Show("You guessed the colour correct!");
        addEarnings = currentBet + 10;
        totalGrapes = totalGrapes + addEarnings;
    }
    // Only Number correct
    if (ballPos == arraypos && ballPos != arrayBlack || ballPos == arraypos && ballPos != arrayRed)
    {
        MessageBox.Show("You guessed only the number correctly!");
        addEarnings = currentBet * 35;
        totalGrapes = totalGrapes + addEarnings;
    }
    // Nothing correct
    else if (ballPos != arraypos && ballPos != arrayEven || ballPos != arraypos && ballPos != arrayOdd)
    {
        MessageBox.Show("You have failed to guess the number or colour correctly.");                 
    }
}