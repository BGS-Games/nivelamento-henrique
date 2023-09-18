using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CardSystem;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PowerDictionaryTests
{
    [Test]
    public void Given_a_key_with_card_name_should_return_card_power_if_it_exists_in_dictionary()
    {
        PowerDictionary powerDictionary = new PowerDictionary();

        Assert.That(powerDictionary.GetValue("4.clubs"), Is.EqualTo(-1));

        powerDictionary.SetValue("4.clubs", 5);

        Assert.That(powerDictionary.GetValue("4.clubs"), Is.EqualTo(5));
    }

    [Test]
    public void From_a_power_dictionary_method_returns_a_power_dictionary()
    {
        string[] values = { "4", "5", "6", "7", "J", "Q", "K", "A", "2", "3" };
        string[] suits = { "clubs", "hearts", "spades", "diamonds" };
        string[] manilhas = { "4.clubs", "7.hearts", "A.spades", "7.diamonds" };

        PowerDictionary powerDictionary = PowerDictionaryCreator.CreateTrucoMineiroDictionary();

        Assert.That(powerDictionary.GetValue("4.clubs"), Is.EqualTo(14));
        Assert.That(powerDictionary.GetValue("7.hearts"), Is.EqualTo(13));
        Assert.That(powerDictionary.GetValue("A.spades"), Is.EqualTo(12));
        Assert.That(powerDictionary.GetValue("7.diamonds"), Is.EqualTo(11));
        
        Assert.That(powerDictionary.GetValue("7.spades"), Is.EqualTo(4));

        var i = 1; 

        foreach (var v in values)
        {
            foreach (var s in suits)
            {
                var cardName = v + "." + s; 
                if (!manilhas.Contains(cardName))
                {
                    Assert.That(powerDictionary.GetValue(cardName), Is.EqualTo(i));
                }
                
            }
            i++;
        }
        

    }
}
