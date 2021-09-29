using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Smad.UserControls {

    public class CardViewList : FlowLayoutPanel {

        private readonly List<Card> cards;

        public bool isUnselected = true;

        public event EventHandler SelectedChanged;
        public event EventHandler CardDobleClick;

        public bool IsUnselected {
            get { return isUnselected; }
            set {
                isUnselected = value;
                if (value == false && cards.Count != 0) {
                    cards[0].GetCard().Selected();
                    SelectedCard = cards.SingleOrDefault(a => a.GetCard().IsSelected == true);
                    SelectedChanged?.Invoke(null, null);
                }
            }
        }
        public Card SelectedCard { get; set; }

        public CardViewList() {
            cards = new List<Card>();
            AutoScroll = true;
            Click += CardViewList_Click;
        }

        public void AddCard(Card card) {
            cards.Add(card);

            var cardView = card.GetCard();
            cardView.SelectedChanged += CardView_SelectedChanged;
            cardView.CardDoubleClick += CardView_CardDoubleClick;
            Controls.Add(cardView);
        }

        private void CardViewList_Click(object sender, EventArgs e) {
            if (IsUnselected) {
                foreach (var card in cards) {
                    card.GetCard().UnSelected();
                }

                if (SelectedCard != null) {
                    SelectedCard = null;
                    SelectedChanged?.Invoke(null, null);
                }
            }
        }
        private void CardView_SelectedChanged(object sender, EventArgs e) {
            foreach (var card in cards) {
                card.GetCard().UnSelected();
            }

            var cardView = (CardView)sender;
            cardView.Selected();

            if (SelectedCard is null) {
                SelectedCard = cards.SingleOrDefault(a => a.GetCard().IsSelected == true);
                SelectedChanged?.Invoke(null, null);
            } else if (!SelectedCard.GetCard().Equals(cardView)) {
                SelectedCard = cards.SingleOrDefault(a => a.GetCard().IsSelected == true);
                SelectedChanged?.Invoke(null, null);
            }
        }
        private void CardView_CardDoubleClick(object sender, EventArgs e) {
            CardDobleClick?.Invoke(null, null);
        }

        public void SelectedIndex(int index = 0) {
            foreach (var card in cards) {
                card.GetCard().UnSelected();
            }

            var cardView = cards[0].GetCard();
            cardView.Selected();

            if (SelectedCard is null) {
                SelectedCard = cards.SingleOrDefault(a => a.GetCard().IsSelected == true);
                SelectedChanged?.Invoke(null, null);
            } else if (!SelectedCard.GetCard().Equals(cardView)) {
                SelectedCard = cards.SingleOrDefault(a => a.GetCard().IsSelected == true);
                SelectedChanged?.Invoke(null, null);
            }
        }
    }

    public class Card {

        private readonly CardView card;

        private string title;
        private Color color;
        private Image icon;

        public string Title {
            get { return title; }
            set { title = value; card.TitleText.Text = value; }
        }
        public Color Color {
            get { return color; }
            set { color = value; card.CardPanel.BackColor = value; }
        }
        public Image Icon {
            get { return icon; }
            set { icon = value; card.IconImage.Image = value; }
        }

        public Card(int width = 250, int height = 250) {
            card = new CardView(width, height);
        }

        public CardView GetCard() {
            return card;
        }
    }
}