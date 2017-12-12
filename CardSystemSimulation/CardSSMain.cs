using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardSystemSimulation
{
    public partial class CardSystemSimulation : Form
    {
        public CardSystemSimulation()
        {
            InitializeComponent();
        }
        CardSystemSimulation instance;

        List<int> cards;
        int nectar = 0;
        List<int> decks;
        List<int> waitLines;

        private void CardSSMain_Load( object sender, EventArgs e )
        {
            cards = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4 };
            SuffleCard();
            nectar = 0;
            decks = new List<int>();
            waitLines = new List<int>();
            instance = sender as CardSystemSimulation;
            Button[] buttons = new Button[4] { instance.Card1, instance.Card2, instance.Card3, instance.Card4 };

            int tempValue = cards.Count / 2;
            for ( int i = 0; i < tempValue; i++ )
            {
                decks.Add( cards[i] );
                buttons[i].Text = cards[i].ToString();
                waitLines.Add( cards[i + tempValue] );
            }
            nectar = 0;
            nectarValue.Text = "0";
            MessageBox.Text = "초기화 완료";

        }

        private void Card_Click( object sender, EventArgs e )
        {
            Button selectedCard = sender as Button;
            int cardValue = int.Parse( selectedCard.Text );
            for ( int i = 0; i < decks.Count; i++ )
            {
                // 클릭한 버튼값과 덱 카드값이 같으면
                if( decks[i] == cardValue )
                {
                    // 대기열에 클릭한 카드값 추가
                    waitLines.Add( decks[i] );
                    // 덱에 대기열 0번째 값 추가
                    selectedCard.Text = waitLines[0].ToString();
                    decks.Add( waitLines[0] );
                    // 대기열에서 0번째 값 제거
                    waitLines.RemoveAt( 0 );
                    // 덱에서 클릭한 카드값 제거
                    decks.RemoveAt( i );
                    nectar++;
                    instance.nectarValue.Text = nectar.ToString();
                    break;
                }
            }
            MessageBox.Text = "";
            for( int i = 0; i < waitLines.Count; i++ )
            {
                MessageBox.Text += waitLines[i].ToString() + ", ";
            }
        }

        private void Suffle_Click( object sender, EventArgs e )
        {
            SuffleCard();
        }

        private void SuffleCard()
        {
            Random rnd = new Random();
            for( int i = 0; i < cards.Count-1; i++ )
            {
                int randomIndex = rnd.Next( i, cards.Count );
                int tempItem = cards[randomIndex];
                cards[randomIndex] = cards[i];
                cards[i] = tempItem;
            }

            MessageBox.Text = "셔플링 완료.";
        }

        private void Reset_Click( object sender, EventArgs e )
        {
            CardSSMain_Load( this, null );
        }
    }
}
