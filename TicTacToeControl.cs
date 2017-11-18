using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TicTacToeControl : MonoBehaviour {

	public SquareState[] board = new SquareState[9];
	public bool xTurn = true;
	
	public Text turnIndicatorLandscape;
	
	public GameObject[] buttonsLandscape;
	public Image[] squaresLandscape;
	public Text[] squareTextsLandscape;
	
	public Sprite oImage;
	public Sprite xImage;
	
	public void ButtonClick(int squareIndex){
		
		buttonsLandscape[squareIndex].SetActive(false);
		squaresLandscape[squareIndex].gameObject.SetActive(true);
		
		if(xTurn){
		
		squaresLandscape[squareIndex].sprite = xImage;
		squareTextsLandscape[squareIndex].text="X";
		
		board[squareIndex] = SquareState.Xcontrol;
		xTurn= false;
		turnIndicatorLandscape.text = "O's Turn";
		
		
	}
	
	else{
		
		squaresLandscape[squareIndex].sprite = oImage;
		squareTextsLandscape[squareIndex].text="O";
		
		board[squareIndex] = SquareState.Ocontrol;
		xTurn= true;
		turnIndicatorLandscape.text = "X's Turn";
		
		
		
		
	}
	
		
		
	}
	
	

}
