using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTestsNewTestScript
{
    [Test]
    public void TakeDamage_ReducesCurrentHealth()
    {
        var health = new Health(100);   // Arrange

        health.TakeDamage(30);          // Act

        Assert.AreEqual(70, health.Current);  // Assert
    }

    [Test]
    public void TakeDamage_NeverGoesBelowZero()
    {
        var health = new Health(50);

        health.TakeDamage(999);

        Assert.AreEqual(0, health.Current);
        Assert.IsTrue(health.IsDead);
    }

    [Test]
    public void Heal_NeverExceedsMax()
    {
        var health = new Health(100);
        health.TakeDamage(20);

        health.Heal(500);

        Assert.AreEqual(100, health.Current);
    }
}
