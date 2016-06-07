using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dodgy_Circle
{
    public partial class GameWind : Form
    {
        private Game game = new Game();

        private Stopwatch _timer = new Stopwatch();
        private double _lastTime;
        private long _frameCounter;

        public GameWind()
        {
            InitializeComponent();
            _lastTime = 0.0;
            _timer.Start();
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            //Work out how long since we were last here in seconds
            double gameTime = _timer.ElapsedMilliseconds / 1000.0;
            double elapsedTime = gameTime - _lastTime;
            _lastTime = gameTime;
            _frameCounter++;
            Console.WriteLine(_lastTime);
            /*

                //Perform any animation
                _player1.Update(gameTime, elapsedTime);
                _player2.Update(gameTime, elapsedTime);
                _ball.Update(gameTime, elapsedTime);

                //Draw the scores
                player1Score.Text = gameState.Player1Score.ToString();
                player1Score.Refresh();
                player2Score.Text = gameState.Player2Score.ToString();
                player2Score.Refresh();

                //and the game objects
                _player1.Draw();
                _player2.Draw();
                _ball.Draw();
        */

            //Force the next Paint()
            //this.Invalidate();
            //Graphics g = canvas.CreateGraphics();
            //game.startGraphics(g);
        }
        private void GameWind_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.stopGame();
        }

    }
}
