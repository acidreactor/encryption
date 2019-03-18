using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Collections;

namespace ShifrB
{
    public class Shifrator
    {

        #region Алгоритм XOR
        public static void XOR(string filename, string outputFilename, string key)
        {
            //получаем массив байт
            byte[] KeyByte = Encoding.ASCII.GetBytes(key);


            StreamReader rdr = new StreamReader(filename);
            StreamWriter wrt = new StreamWriter(outputFilename);

            int KeyLength = key.Length;

            char[] Buffer = new char[KeyLength];

            int BufferRead = 0;
            while ((BufferRead = rdr.Read(Buffer, 0, KeyLength)) > 0)
            {
                byte[] BufferByte = Encoding.ASCII.GetBytes(Buffer);

                byte[] NewBuffer = new byte[BufferRead];
                for (int i = 0; i < BufferRead; i++)
                {
                    NewBuffer[i] = (byte)((int)KeyByte[i] ^ (int)BufferByte[i]);
                }

                wrt.Write(Encoding.ASCII.GetChars(NewBuffer));

            }


            rdr.Close();
            wrt.Close();

        }

        //реализация алгоритма XOR
        public static string XOR(string sourceText, string key)
        {
            //получаем массив байт для шифрования
            byte[] KeyByte = Encoding.ASCII.GetBytes(key);

            //вычисляем длины текста и ключа
            int KeyLength = key.Length;
            int SourceLength = sourceText.Length;

            //создаем выходной буфер
            char[] Buffer = new char[KeyLength];

            //создаем выходную строку
            string OutputString = "";

            //в цикле проходим по входной строке
            int Index = 0;
            string CurrentBlock = "";
            while (Index < SourceLength)
            {
                //получаем часть строки для шифрования
                if (Index + KeyLength <= SourceLength)
                    CurrentBlock = sourceText.Substring(Index, KeyLength);
                else
                    CurrentBlock = sourceText.Substring(Index, SourceLength - Index);

                //получаем массив байт текущего блока
                byte[] BufferByte = Encoding.Default.GetBytes(CurrentBlock);

                //для каждого байта применяем операцию XOR
                byte[] NewBuffer = new byte[CurrentBlock.Length];
                for (int i = 0; i < CurrentBlock.Length; i++)
                {
                    NewBuffer[i] = (byte)((int)KeyByte[i] ^ (int)BufferByte[i]);
                }

                //формируем выходную строку
                OutputString += Encoding.Default.GetString(NewBuffer);

                Index += CurrentBlock.Length;

            }

            return OutputString;
        }
        #endregion

        #region Алгоритм Цезаря
        //реализация алгоритма Цезаря
        private static string Caesar(string sourceText, int rotn, string alphabet)
        {
            //формируем длины исздной строки и алфивита
            int SourceLength = sourceText.Length;
            int AlphabetLength = alphabet.Length;

            //создаем выодную строку
            string OutputString = "";

            //в цикле проходим по строке
            for (int i = 0; i < SourceLength; i++)
            {
                //получаем текущий номер символа в алфивете
                int CurCharPos = alphabet.IndexOf(sourceText[i]);

                //если в алфавите нет такого символа - оставляем его как есть
                if (CurCharPos == -1)
                {
                    OutputString += sourceText[i];
                }
                    //иначе сдвигаем 
                else
                {
                    OutputString += alphabet[(CurCharPos + rotn) % AlphabetLength];
                }
            }

            return OutputString;
        }

        //реализация алгоритма Цезаря (Английский алфавит)
        public static string CaesarEN(string sourceText, int rotn)
        {
            string Aplphabet = "abcdefghijklmopqrstuvwxyz";
            return Caesar(sourceText, rotn, Aplphabet);
        }

        //реализация алгоритма Цезаря (Русский алфавит)
        public static string CaesarRU(string sourceText, int rotn)
        {
            string Aplphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            return Caesar(sourceText, rotn, Aplphabet);
        }
        #endregion

        #region Алгоритм DES

        private static byte[] GenerateNewKey()
        {
            const int iterations = 300;
            var salt = new byte[] { 20, 30, 40, 50, 60, 70, 80, 90 };
            var keyGenerator = new Rfc2898DeriveBytes("password", salt, iterations);
            return keyGenerator.GetBytes(32);
        }

        /*private static String BitArrayToStr(BitArray ba)
        {
            byte[] strArr = new byte[ba.Length / 8];

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            for (int i = 0; i < ba.Length / 8; i++)
            {
                for (int index = i * 8, m = 1; index < i * 8 + 8; index++, m *= 2)
                {
                    strArr[i] += ba.Get(index) ? (byte)m : (byte)0;
                }
            }

            return encoding.GetString(strArr);
        }

        private static BitArray Sdvig(BitArray ba, int d)
        {
            for (int i = 0; i < d; i++)
            {
                bool left = ba[0];

                for (int q = 1; q < ba.Count; q++)
                {
                    ba[q - 1] = ba[q];
                }
                ba[ba.Length - 1] = left;
            }
            return ba;
        }

        public static string Gost(string sourceText)
        {
            int[] SS = { 1, 15, 13, 0, 5, 7, 10, 4, 9, 2, 3, 14, 6, 11, 8, 12 }; 
            
            string Key = "jBAlxvWC5zGKLM3O1yng22FguyWj3y8H";

            string[] SubBlocks = GetSubBlocks(sourceText);

            string[] K = new string[8];
            K[0] = Key.Substring(0,4);
            K[1] = Key.Substring(5,4);
            K[2] = Key.Substring(9,4);
            K[3] = Key.Substring(13,4);
            K[4] = Key.Substring(17,4);
            K[5] = Key.Substring(21,4);
            K[6] = Key.Substring(25,4);
            K[7] = Key.Substring(29,4);

            int SourceLength = sourceText.Length - 1;

            string OutputString = "";

            for (int round = 0; round < 32; round++)
            {
                for (int i = 0; i < SubBlocks.Length; i+=2)
                {
                    string LR = SubBlocks[i];
                    string RR = SubBlocks[i + 1];

                    string s1 = XOR(RR, K[i % 8]);

                    BitArray Bits = new BitArray(Encoding.Default.GetBytes(s1));
                    BitArray NewBits = (BitArray)Bits.Clone();

                    for (int q = 0; q < 8; q++)
                    {
                        for (int r = 0; r < 4; r++)
                        {
                            NewBits[q * 8 + r] = Bits[q * 8 + SS[q, r]];
                        }
                    }

                    string s2 = BitArrayToStr(Sdvig(NewBits,11));





                    
                }
            }




            return OutputString;
        }*/

        //Функция шифрования по алгоритму DES
        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            //проверяем входные параметры
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;

            //создаем экземпляр класса для шифрования
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                //заполняем параметры шифрования
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                //созадем интерфейс для ширования
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                //открываем поток для чтения шифрованного тектса
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    //на основе откртого потока создаем новый поток для шифрования
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //читаем зашифрованные данные
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;

        }

        //Функция дешифрования по алгоритму DES
        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {

            //проверяем входные параметры
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            string plaintext = null;

            //создаем экземпляр класса для шифрования
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                //заполняем параметры шифрования
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                //созадем интерфейс для деширования
                ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                //открываем поток для чтения шифрованного тектса
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    //на основе откртого потока создаем новый поток для дешифрования
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            //читаем дешифрованные данные
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }

        //Функция генерации секретного ключа
        public static string GenSecretKey()
        {
            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            {
                return Encoding.Default.GetString(myTripleDES.Key);
            }
        }

        //Функция генерации вектора инициализации
        public static string GenInitializingVector()
        {
            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            {
                return Encoding.Default.GetString(myTripleDES.IV);
            }
        }

        public static string DESEncrypt(string sourceText, string key, string iv)
        {
            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            { 
                byte[] encrypted = EncryptStringToBytes(sourceText, Encoding.Default.GetBytes(key), Encoding.Default.GetBytes(iv));

                return Encoding.Default.GetString(encrypted);
            }

        }

        public static string DESDecrypt(string sourceText, string key, string iv)
        {
            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            {
                string roundtrip = DecryptStringFromBytes(Encoding.Default.GetBytes(sourceText), Encoding.Default.GetBytes(key), Encoding.Default.GetBytes(iv));

                return roundtrip;
            }
        }


        #endregion


    }
}
