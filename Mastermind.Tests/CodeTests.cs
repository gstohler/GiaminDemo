using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch_1_Mastermind;

namespace Mastermind.Tests
{
    [TestClass]
    public class CodeTests
    {
        [TestMethod]
        public void FromString_erstellt_gültigen_code()
        {
            // Arrange
            var input = "1234";

            // Act
            var code = Code.FromString(input);

            // Assert
            code.Zahl1.Should().Be("1");
            code.Zahl2.Should().Be("2");
            code.Zahl3.Should().Be("3");
            code.Zahl4.Should().Be("4");
        }

        [TestMethod]
        [DataRow("1231", "1231")]
        public void IsCodeGleichWie_erfolgreich_wenn_beide_codes_gleich_sind(string codeText1, string codeText2)
        {
            // Arrange
            var code1 = Code.FromString(codeText1);
            var code2 = Code.FromString(codeText2);

            // Act
            var istGleich = code1.IsCodeGleichWie(code2);

            // Assert
            istGleich.Should().BeTrue();
        }

        [TestMethod]
        [DataRow("1231", "1233")]
        [DataRow("1111", "2111")]
        [DataRow("1111", "1211")]
        [DataRow("1111", "1121")]
        [DataRow("1111", "1112")]
        public void IsCodeGleichWie_failt_wenn_beide_codes_nicht_gleich_sind(string codeText1, string codeText2)
        {
            // Arrange
            var code1 = Code.FromString(codeText1);
            var code2 = Code.FromString(codeText2);

            // Act
            var istGleich = code1.IsCodeGleichWie(code2);

            // Assert
            istGleich.Should().BeFalse();
        }

        [TestMethod]
        [DataRow("4321", "4321", 4)]
        [DataRow("1133", "1133", 4)]
        [DataRow("1234", "1111", 1)]
        [DataRow("1234", "1114", 2)]
        [DataRow("1234", "1134", 3)]
        [DataRow("1234", "4321", 0)]
        [DataRow("4444", "1111", 0)]
        public void BerechneRichtigeZahlUndRichtigerOrt_berechnet_richtiges_resultat_für_codes(string codeText1, string codeText2, int erwartetesResultat)
        {
            // Arrange
            var code1 = Code.FromString(codeText1);
            var code2 = Code.FromString(codeText2);

            // Act
            var richtigeZahlUndOrt = code1.BerechneRichtigeZahlUndRichtigerOrt(code2);

            // Assert
            richtigeZahlUndOrt.Should().Be(erwartetesResultat);
        }

        [TestMethod]
        [DataRow("1121", "1313", 1)]
        [DataRow("1313", "1121", 1)]
        [DataRow("1121", "1313", 1)]
        [DataRow("1122", "2211", 4)]
        [DataRow("1122", "2233", 2)]
        [DataRow("1222", "2333", 1)]
        [DataRow("1222", "2221", 2)]
        [DataRow("1234", "1123", 2)]
        [DataRow("1234", "4123", 4)]
        [DataRow("1234", "4423", 3)]
        public void BerechneRichtigeZahlenInAntwort_berechnet_richtiges_resultat_für_codes(string geheimText, string antwortText, int erwartetesResultat)
        {
            // Arrange
            var geheimCode = Code.FromString(geheimText);
            var antwortCode = Code.FromString(antwortText);

            // Act
            var richtigeZahlen = Code.BerechneRichtigeZahlenInAntwort(geheimCode, antwortCode);

            // Assert
            richtigeZahlen.Should().Be(erwartetesResultat);
        }
    }
}
