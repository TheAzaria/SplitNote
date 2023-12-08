namespace Azaria_Reed_CIS285_12103_FinalProject
{
    partial class FrmSplitNote
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMethod = new Label();
            lblQuestion = new Label();
            lblAnswer = new Label();
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            lblQueue = new Label();
            lstQueue = new ListBox();
            btnReview = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblMethod.Location = new Point(108, 10);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(284, 29);
            lblMethod.TabIndex = 0;
            lblMethod.Text = "The QA Split-Page Method";
            lblMethod.TextAlign = ContentAlignment.MiddleCenter;
            lblMethod.Click += LblMethod_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(12, 69);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(119, 25);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question (Q)";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += LblQuestion_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswer.Location = new Point(252, 69);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(102, 25);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "Answer (A)";
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            lblAnswer.Click += LblAnswer_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(12, 106);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(218, 50);
            txtQuestion.TabIndex = 3;
            txtQuestion.DoubleClick += TxtQuestion_DoubleClick;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.Location = new Point(252, 106);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(218, 50);
            txtAnswer.TabIndex = 4;
            txtAnswer.DoubleClick += TxtAnswer_DoubleClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(12, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(252, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblQueue.Location = new Point(12, 239);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(110, 25);
            lblQueue.TabIndex = 7;
            lblQueue.Text = "Card Queue";
            lblQueue.TextAlign = ContentAlignment.MiddleCenter;
            lblQueue.Click += LblQueue_Click;
            // 
            // lstQueue
            // 
            lstQueue.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstQueue.FormattingEnabled = true;
            lstQueue.ItemHeight = 18;
            lstQueue.Location = new Point(12, 276);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(240, 166);
            lstQueue.TabIndex = 8;
            // 
            // btnReview
            // 
            btnReview.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReview.Location = new Point(376, 276);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(94, 29);
            btnReview.TabIndex = 9;
            btnReview.Text = "&Review";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += BtnReview_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(376, 311);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(376, 412);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // FrmSplitNote
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(482, 453);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnReview);
            Controls.Add(lstQueue);
            Controls.Add(lblQueue);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Controls.Add(lblAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMethod);
            Name = "FrmSplitNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplitNote";
            Load += LblMethod_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMethod;
        private Label lblQuestion;
        private Label lblAnswer;
        private TextBox txtQuestion;
        private TextBox txtAnswer;
        private Button btnClear;
        private Button btnSave;
        private Label lblQueue;
        private ListBox lstQueue;
        private Button btnReview;
        private Button btnDelete;
        private Button btnClose;
    }
}