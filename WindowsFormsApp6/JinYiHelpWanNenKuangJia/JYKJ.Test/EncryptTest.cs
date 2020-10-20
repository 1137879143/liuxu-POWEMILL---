using JinYiHelp.CryptHelp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JinYiHelp.CodingHelp;

namespace JYKJTest
{
    [TestClass]
    public class EncryptTest
    {
        [TestMethod]
        public void Md5Test()
        {
            string md5 = CryptHelper.MD5("bbs");
            Assert.AreEqual(md5, "28aa17dc7c163e7e7cf88d0c556a729b");
        }

        [TestMethod]
        public void ShaTest()
        {
            string sha = CryptHelper.SHA1("bbs").ToLower();
            Assert.AreEqual(sha, "50a7c871e6420c4bda76e49098db1dd483d74a71");
        }

        [TestMethod]
        public void DesTest()
        {
            string des = "bbs.125.la";
            string pass = "12345678";
          
            byte[] bin= CryptHelper.DesEncrypt(des, pass);

            byte[] de_bin= CryptHelper.DesDecrypt(bin,pass);

            string str = CodingHelper.ByteToString(de_bin);
            Assert.AreEqual(str, des);

        }

        [TestMethod]
        public void HexText()
        {
            string str = "6C61";
            byte[] bin = CryptHelper.HexToByte(str);
            string hex = CryptHelper.ByteToHex(bin);

            Assert.AreEqual(str, hex);

        }


        [TestMethod]
        public void AesTest() {
            string aes = "123456".AESEncrypt();// AES加密为密文
            string s = aes.AESDecrypt(); //AES解密为明文
            Assert.AreEqual(s, "123456");
        }

        [TestMethod]
        public void SHA256Test()
        {
            string str = "bbs.125.la".SHA256();
            Assert.AreEqual(str, "7461345e9a5d9604918eddae63276ea309f8d3091b430609e18c538d79b47140");
        }



        /// <summary>
        /// 跟精易的 文本_加密一致
        /// </summary>
        [TestMethod]
        public void StringEncryptTest()
        {

            string str = CryptHelper.StringEncrypt("bbs.125.la", "12345");
          
            Assert.AreEqual(str, "7272633E2122253E7C717CCB0EEA8");

        }

        [TestMethod]
        public void StringDeEncryptTest()
        {
            string str = CryptHelper.StringDecrypt("7272633E2122253E7C717CCB0EEA8", "12345");
            Assert.AreEqual(str, "bbs.125.la");
        }

    }
}
