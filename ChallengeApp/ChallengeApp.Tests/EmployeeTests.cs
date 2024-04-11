namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPositiveScores_ShouldCorrectResult()
        {
            // arrange
            var employee1 = new Employee("Monika", "Kowalska", 25);
            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(4);

            // act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(15, result);
        }
        [Test]
        public void WhenEmployeeCollectNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var employee2 = new Employee("Jan", "Nowak", 42);
            employee2.AddScore(-5);
            employee2.AddScore(-8);
            employee2.AddScore(-9);

            // act
            var result = employee2.Result;

            // assert
            Assert.AreEqual(-22, result);
        }
        [Test]
        public void WhenEmployeeCollectPositiveAndNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var employee3 = new Employee("Marek", "Korek", 38);
            employee3.AddScore(-7);
            employee3.AddScore(6);
            employee3.AddScore(-2);

            // act
            var result = employee3.Result;

            // assert
            Assert.AreEqual(-3, result);
        }
    }
}