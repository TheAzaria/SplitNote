using System.Windows.Forms.Design;

namespace Azaria_Reed_CIS285_12103_FinalProject
{
    public partial class FrmSplitNote : Form
    {
        // The public FrmSplitNote() method uses the InitializeComponent method to, expectedly, initialize its form's components.
        public FrmSplitNote()
        {
            // The InitializeComponent() method creates objects from the appropriate control classes and assigns those objects to the appropriate variables.
            InitializeComponent();
        }

        // These statements create lists of string elements to hold the user's questions and corresponding answers, respectively.
        List<string> Questions = new List<string>();
        List<string> Answers = new List<string>();

        // This expression-bodied method responds to the Click event of the lblMethod label.
        // It uses the Show() method of the MessageBox class to display information about the QA Split-Page Method to the user.
        private void LblMethod_Click(object sender, EventArgs e) =>
            MessageBox.Show("The QA Split-Page Method is a note-taking system " +
                            "involving dividing your page into two columns: one for questions and one for answers! " +
                            "Not only does it provide a clear structure for your notes, " +
                            "but it also encourages active learning, easing the study and review process!",
                            "The QA Split-Page Method");

        // This expression-bodied method responds to the Click event of the lblQuestion label.
        // It uses the Show() method of the MessageBox class to instruct the user.
        private void LblQuestion_Click(object sender, EventArgs e) =>
            MessageBox.Show("Please type your question below.",
                            "Question (Q)");

        // This expression-bodied method responds to the Click event of the lblAnswer label.
        // Likewise, it uses the Show() method of the MessageBox class to instruct the user.
        private void LblAnswer_Click(object sender, EventArgs e) =>
            MessageBox.Show("Please type your question's answer below.",
                            "Answer (A)");

        // The expression-bodied method responds to the Double Click event of the txtQuestion textbox. 
        // In the event, it clears the contents of the txtQuestion textbox.
        private void TxtQuestion_DoubleClick(object sender, EventArgs e) => txtQuestion.Text = "";

        // Similarly, the expression-bodied method responds to the Double Click event of the txtAnswer textbox.
        // In the event, it clears the contents of the txtAnswer textbox.
        private void TxtAnswer_DoubleClick(object sender, EventArgs e) => txtAnswer.Text = "";

        // The BtnClear_Click() method handles the Click event of the btnClear button.
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // These statements clear the contents of both textboxes to prepare for a new entry.
            txtQuestion.Text = "";
            txtAnswer.Text = "";
        }

        // The BtnSave_Click method handles the Click event of the btnSave button.
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // These statement retrieve the user's textbox entries.
            string question = txtQuestion.Text.Trim();
            string answer = txtAnswer.Text.Trim();

            // The block ensures the entries' presence and validity.
            bool validEntries = true;
            if (question.Trim() == "")
            {
                MessageBox.Show("Please enter a question.", "Question Entry Error");
                validEntries = false;
            }
            if (answer.Trim() == "" && validEntries)
            {
                MessageBox.Show("Please enter an answer.", "Answer Entry Error");
                validEntries = false;
            }
            if (Questions.Contains(question) && validEntries)
            {
                DialogResult response = MessageBox.Show("You are saving a repeat question. Do you still want to proceed?",
                                "Question Entry Notice",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
                if (response == DialogResult.No)
                    validEntries = false;
            }

            // This if statment ensures that the program only saves the present and valid entries.
            if (validEntries)
            {
                // These statements use the Add method of the Questions and Answers lists to save the user's question and answer, respectively.
                Questions.Add(question);
                Answers.Add(answer);

                // Accordingly, this statement uses the Add method of lstQueue listbox's Item collection to update the listbox.
                lstQueue.Items.Add(question);

                // These statements clear the contents of the txtQuestion and txtAnswer textboxes, respectively.
                txtQuestion.Text = "";
                txtAnswer.Text = "";
            }
        }

        // This expression-bodied method responds to the Click event of the lblQueue label.
        // Familiarly, it uses the Show() method of the MessageBox class to instruct the user.
        private void LblQueue_Click(object sender, EventArgs e) =>
            MessageBox.Show("Access your card queue below.",
                            "Queue");

        // The BtnReview_Click method handles the Click event of the btnReview button.
        private void BtnReview_Click(object sender, EventArgs e)
        {
            // This statement retrieves the flashcard that the user selects from the Card Queue.
            int index = lstQueue.SelectedIndex;

            // The block ensures the selection's presence.
            bool validSelection = true;
            if (index == -1)
            {
                MessageBox.Show("Please make a selection.", "Queue Selection Error");
                validSelection = false;
            }

            // This if statment ensures that the program retrieves an existing card.
            if (validSelection)
            {
                // These statements retrieve the flashcard's question and answer for the user's review.
                txtQuestion.Text = Questions[index];
                txtAnswer.Text = Answers[index];
            }
        }

        // The BtnDelete_Click method handles the Click event of the btnDelete button.
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Familiarly, this statement retrieves the flashcard that the user selects from the Card Queue.
            int index = lstQueue.SelectedIndex;

            // Similarly, the block ensures the selection's presence.
            bool validSelection = true;
            if (index == -1)
            {
                MessageBox.Show("Please make a selection.", "Queue Selection Error");
                validSelection = false;
            }

            // Conversely, this if statment ensures that the program deletes an existing card.
            if (validSelection)
            {
                // These statements use the RemoveAt method of the Questions and Answers lists to delete the user's question and answer, respectively.
                Questions.RemoveAt(index);
                Answers.RemoveAt(index);

                // This statement uses the RemoveAt method of lstQueue listbox's Item collection to update the listbox accordingly.
                lstQueue.Items.RemoveAt(index);
            }
        }

        // The BtnClose_Click method handles the Click event of the btnClose button.
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // This statement closes the SplitNote Windows Forms application.
            this.Close();
        }
    }
}