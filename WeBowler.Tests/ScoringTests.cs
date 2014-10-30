using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace WeBowler.Tests
{
    [TestClass]
    public class ScoringTests
    {
        [TestMethod]
        public void ScoreNotSparesAndNotStrikesNoData()
        {
            Frame[] frames = new Frame[10];
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(score, 0);
        }

        [TestMethod]
        public void ScoreNotSparesAndNotStrikesWithDataOneFrame()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 4
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(score, 7);
        }

        [TestMethod]
        public void ScoreNotSparesAndNotStrikesWithDataMultipleFrames()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 4
            };
            frames[1] = new Frame
            {
                Bowl1 = 1,
                Bowl2 = 1
            };
            frames[2] = new Frame
            {
                Bowl1 = 5,
                Bowl2 = 4
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(score, 18);
        }

        [TestMethod]
        public void ScoreWithSparesWithDataOneFrame()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 7
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(10, score);
        }

        [TestMethod]
        public void ScoreWithSparesWithDataMultipleFrames()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 7
            };
            frames[1] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 1
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(17, score);
        }

        [TestMethod]
        public void ScoreWith2SparesWithDataMultipleFrames()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 7
            };
            frames[1] = new Frame
            {
                Bowl1 = 7,
                Bowl2 = 3
            };
            frames[2] = new Frame
            {
                Bowl1 = 7,
                Bowl2 = 1
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(42, score);
        }

        [TestMethod]
        public void ScoreWithStrikesWithDataOneFrame()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 10,
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(10, score);
        }

        [TestMethod]
        public void ScoreWithStrikesWithDataMultipleFrames()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 10,
            };
            frames[1] = new Frame
            {
                Bowl1 = 3,
                Bowl2 = 1
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(18, score);
        }

        [TestMethod]
        public void ScoreWith2StrikesWithDataMultipleFrames()
        {
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 10,
            };
            frames[1] = new Frame
            {
                Bowl1 = 10,
            };
            frames[2] = new Frame
            {
                Bowl1 = 7,
                Bowl2 = 1
            };
            int score = Scorer.CalculateScore(frames);
            Assert.AreEqual(52, score);
        }

        [TestMethod]
        public void ScoreWithStrikesWithDataOneFrame_Interaction()
        {
            var x = Substitute.For<Frame>();
            Frame[] frames = new Frame[10];
            frames[0] = new Frame
            {
                Bowl1 = 10,
            };
            frames[1] = x;
            int score = Scorer.CalculateScore(frames);

            x.Received().GetTotalRawScore();
        }
        [TestMethod]
        public void interaction_based_assertions()
        {
            IEmailService es = Substitute.For<IEmailService>();
            Greeting sut = new Greeting(es);
            sut.Build();
            es.Received().Send("message for email");
        }
    }
}
