namespace HighScoreGUI
{
    partial class Main
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
            lbxPlayers=new ListBox();
            lbxHighScoresPerGame=new ListBox();
            lbxGames=new ListBox();
            lbxHighScoresPerPlayer=new ListBox();
            textBox1=new TextBox();
            SuspendLayout();
            // 
            // lbxPlayers
            // 
            lbxPlayers.FormattingEnabled=true;
            lbxPlayers.ItemHeight=20;
            lbxPlayers.Location=new Point(12, 12);
            lbxPlayers.Name="lbxPlayers";
            lbxPlayers.Size=new Size(294, 204);
            lbxPlayers.TabIndex=0;
            // 
            // lbxHighScoresPerGame
            // 
            lbxHighScoresPerGame.FormattingEnabled=true;
            lbxHighScoresPerGame.ItemHeight=20;
            lbxHighScoresPerGame.Location=new Point(312, 12);
            lbxHighScoresPerGame.Name="lbxHighScoresPerGame";
            lbxHighScoresPerGame.Size=new Size(294, 204);
            lbxHighScoresPerGame.TabIndex=1;
            // 
            // lbxGames
            // 
            lbxGames.FormattingEnabled=true;
            lbxGames.ItemHeight=20;
            lbxGames.Location=new Point(12, 234);
            lbxGames.Name="lbxGames";
            lbxGames.Size=new Size(294, 204);
            lbxGames.TabIndex=2;
            // 
            // lbxHighScoresPerPlayer
            // 
            lbxHighScoresPerPlayer.FormattingEnabled=true;
            lbxHighScoresPerPlayer.ItemHeight=20;
            lbxHighScoresPerPlayer.Location=new Point(312, 234);
            lbxHighScoresPerPlayer.Name="lbxHighScoresPerPlayer";
            lbxHighScoresPerPlayer.Size=new Size(294, 204);
            lbxHighScoresPerPlayer.TabIndex=3;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(612, 12);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.Size=new Size(176, 426);
            textBox1.TabIndex=4;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lbxHighScoresPerPlayer);
            Controls.Add(lbxGames);
            Controls.Add(lbxHighScoresPerGame);
            Controls.Add(lbxPlayers);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxPlayers;
        private ListBox lbxHighScoresPerGame;
        private ListBox lbxGames;
        private ListBox lbxHighScoresPerPlayer;
        private TextBox textBox1;
    }
}