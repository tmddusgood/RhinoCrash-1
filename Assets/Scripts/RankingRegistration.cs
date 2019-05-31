using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingRegistration : MonoBehaviour
{
    public Text ScoreText;
    public Text RankingText;
    public Text Initial1_Text;
    public Text Initial2_Text;
    public Text Initial3_Text;
    public Text Initial_Input_Text;
    public InputField newname;

    string Name = null;

    List<string> initial = new List<string>();

    public static int initial_alphabet_index = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = PlayerController.score.ToString();
        initial.Add("A"); initial.Add("B"); initial.Add("C"); initial.Add("D"); initial.Add("E"); initial.Add("F"); initial.Add("G"); initial.Add("H");
        initial.Add("I"); initial.Add("J"); initial.Add("K"); initial.Add("L"); initial.Add("M"); initial.Add("N"); initial.Add("O"); initial.Add("P");
        initial.Add("Q"); initial.Add("R"); initial.Add("S"); initial.Add("T"); initial.Add("U"); initial.Add("V"); initial.Add("W"); initial.Add("X");
        initial.Add("Y"); initial.Add("Z");
    }

    // Update is called once per frame
    void Update()
    {
        Initial_Input_Text.text = initial[initial_alphabet_index];
        Initial1_Text.text = initial[initial_alphabet_index];
        Initial2_Text.text = initial[initial_alphabet_index];
        Initial3_Text.text = initial[initial_alphabet_index];
        
    }

    public void RightArrow()
    {
        RankingRegistration.initial_alphabet_index++;
        if(RankingRegistration.initial_alphabet_index > 25)
        {
            RankingRegistration.initial_alphabet_index -= 26;
            Initial_Input_Text.text = initial[RankingRegistration.initial_alphabet_index];
        }
        Initial_Input_Text.text = initial[RankingRegistration.initial_alphabet_index];
    }

    public void LeftArrow()
    {
        RankingRegistration.initial_alphabet_index--;
        if (RankingRegistration.initial_alphabet_index < 0)
        {
            RankingRegistration.initial_alphabet_index += 26;
            Initial_Input_Text.text = initial[RankingRegistration.initial_alphabet_index];
        }
        Initial_Input_Text.text = initial[RankingRegistration.initial_alphabet_index];
    }

    public void InitialInput()
    {
        Name = newname.GetComponent<Text>().ToString();
    }
}
