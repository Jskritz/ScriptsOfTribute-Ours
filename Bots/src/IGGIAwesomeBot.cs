using ScriptsOfTribute;
using ScriptsOfTribute.AI;
using ScriptsOfTribute.Board;
using ScriptsOfTribute.Serializers;
using ScriptsOfTribute.Board.Cards;
using System.Diagnostics;
using System.Text;
using ScriptsOfTribute.Board.CardAction;
using System.Globalization;

namespace Bots;

public class IGGINode {
    // Tree structure
    public IGGINode? father;
    public List<IGGINode>? children;
    // UCB variables
    private int wins; //number of wins after the i-th move
    private int visits;//number of simulations after the i-th move
    private double exploreParameter = Math.Sqrt(2);//exploration parameter (theoretically equal to √2)

    // game variables
    private SeededGameState gameState;
    private Move move;
    private List<Move> possibleMoves;

    //Constructor
    public IGGINode(SeededGameState gameState, Move? move, IGGINode? father){
        this.wins=0;
        this.visits=0;
        var (newGameState,newMoves) = gameState.ApplyMove(move);
        this.gameState = newGameState;
        this.possibleMoves = newMoves;
        this.father=father;
        this.children=new List<IGGINode>();
        this.move=move;

    }
    // Instantiate all children, a.k.a expand
    public void CreateChilds(){
        foreach(Move move in possibleMoves){
            this.children.Add(new IGGINode(this.gameState,move, this));
        }
    }

    public double CalculateUCG(){
        return 0;
    }

    public double Heuristic(){
        return 0;
    }

}


public class IGGIAwesomeBot : AI
{
    // Heuristic variables
    private int coinValue = 1;
    private int powerValue = 10;
    private int prestigeValue = 5;
    private int patronFavor = 0;
    private int patronNeutral = 20;
    private int patronUnfavour= 50;
    private int cardDraw = 20;
    private int enemyAgent = 30;
    private int cardPurchase = 100;
    // random seeds
    private const ulong botSeed = 42;
    private readonly SeededRandom rng = new(botSeed);

    // calculate heuristic value of current game state
    private double CalculateHeuristic(SeededGameState gameState){
        return 0;
    }

    //execute simulation for the node, go to each child and calculate result (up to a budget)
    private double Rollout(){
        return 0;
    }

    //feedbacks the result of the simulation to each node passed on to reach that result
    private void Backpropagation(double result){

    }

    // Select the best child of the current node => select the action to be taken
    private Move SelectBestChild(IGGINode currentNode){
        return currentNode.move;
    }

    // select patron randomly
    public override PatronId SelectPatron(List<PatronId> availablePatrons, int round)
    {
        return availablePatrons.PickRandom(rng);
    }

    public override Move Play(GameState gameState, List<Move> possibleMoves, TimeSpan remainingTime)
    {
        
        return possibleMoves[0];
    }

    public override void GameEnd(EndGameState state, FullGameState? finalBoardState)
    {
    }
}