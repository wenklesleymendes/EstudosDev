using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Matematica
{

    //A classe matemática principal
    //Conter todos métodos para executar funções matemáticas básicas

    /// <summary>
    /// 
    /// A principal <c>Math</c> classe.
    /// Conter todos métodos para executar funções matemáticas básicas
    /// <list type="bullet">
    /// <item>
    /// <term>Add</term>
    /// <description>Operações de adição</description>
    /// </item>
    /// <item>
    /// <term>Subtract</term>
    /// <description>Operações de subtração</description>
    /// </item>
    /// <item>
    /// <term>Multiplica</term>
    /// <description>Operação de multiplicação</description>
    /// </item>
    /// <item>
    /// <term>Divide</term>
    /// <description>Operação de divisão</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>Essa classe poide adicionar, subtrair, multiplicar e dividir.</para>
    /// <para>Essas operações podem ser executadas em ambos integrantes e doubles</para>
    /// </remarks>
    public class Math
    {
        // Adicionar dois integrantes e retornar o resultado
        /// <summary>
        /// Adiciona dois integrantes <paramref name="a"/> e <paramref name="b"/> e retorna o resultado.
        /// </summary>
        /// <returns>
        /// A soma de dois integrantes
        /// </returns>
        /// <example>
        /// <code>
        /// int c = Math.Add(4, 5);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">Jogar quando um parâmetro é máximo
        /// E o outro é maior que zero.</exception>
        /// Ver<see cref="Math.Add(double, double)"/> Para adicionar doubles.
        /// <seealso cref="Math.Subtract(int, int)"/>
        /// <seealso cref="Math.Multiply(int, int)"/>
        /// <seealso cref="Math.Divide(int, int)"/>
        /// <param name="a">Um inetgrante</param>
        /// <param name="b">Um integrante</param>
        public static int Add(int a, int b)
        {
            // Se qualquer parâmetro é igual ao valor máximo de um integrante
            // E o outro é maior que zero
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Adicionar dois doubles e retornar o reesultado
        /// <summary>
        /// Adiciona dois doubles <paramref name="a"/> e <paramref name="b"/> E retorna o resultado.
        /// </summary>
        /// <returns>
        /// A Soma de dois doubles.
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Math.Add(4.5, 5.4);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">Jogar quando um parâmetro é máximo
        /// E o outro é maior que zero.</exception>
        /// Ver <see cref="Math.Add(int, int)"/> Para adicionar integrantes.
        /// <seealso cref="Math.Subtract(double, double)"/>
        /// <seealso cref="Math.Multiply(double, double)"/>
        /// <seealso cref="Math.Divide(double, double)"/>
        /// <param name="a">Um número de precisão dupla</param>
        /// <param name="b">Um número de precisão dupla</param>
        public static double Add(double a, double b)
        {
            // Se qualquer parâmetro é igual ao valor máximo de um integrante
            // E o outro é maior que zero
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Subtrair um integrante de outro e retornar o reesultado
        /// <summary>
        /// Subtrai <paramref name="b"/> do <paramref name="a"/> E retornar o resultado.
        /// </summary>
        /// <returns>
        /// A diferença entre dois integrantes
        /// </returns>
        /// <example>
        /// <code>
        /// int c = Math.Subtract(4, 5);
        /// if (c > 1)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// Ver <see cref="Math.Subtract(double, double)"/> para subtrair os doubles.
        /// <seealso cref="Math.Add(int, int)"/>
        /// <seealso cref="Math.Multiply(int, int)"/>
        /// <seealso cref="Math.Divide(int, int)"/>
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Subtrair um double de outro e rretornar o resultado
        /// <summary>
        /// subtrair um double <paramref name="b"/> De outro double <paramref name="a"/> e retornar o resultado.
        /// </summary>
        /// <returns>
        ///A diferença entre dois doubles
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Math.Subtract(4.5, 5.4);
        /// if (c > 1)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// Ver <see cref="Math.Subtract(int, int)"/> Para subtrair integrantes.
        /// <seealso cref="Math.Add(double, double)"/>
        /// <seealso cref="Math.Multiply(double, double)"/>
        /// <seealso cref="Math.Divide(double, double)"/>
        /// <param name="a">Um número de precisão dupla</param>
        /// <param name="b">Um número de precisão dupla</param>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplicar dois integrantes e retornar o resultado
        /// <summary>
        /// Multiplica dois integrantes <paramref name="a"/> e <paramref name="b"/> e retorna o resultado.
        /// </summary>
        /// <returns>
        /// O produto de dois integrantes
        /// </returns>
        /// <example>
        /// <code>
        /// int c = Math.Multiply(4, 5);
        /// if (c > 100)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// Ver <see cref="Math.Multiply(double, double)"/> Para multiplicar doubles.
        /// <seealso cref="Math.Add(int, int)"/>
        /// <seealso cref="Math.Subtract(int, int)"/>
        /// <seealso cref="Math.Divide(int, int)"/>
        /// <param name="a">um integrante.</param>
        /// <param name="b">um integrante.</param>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Multiplicar dois doubles e retornar o resultado
        /// <summary>
        /// Multiplica dois doubles <paramref name="a"/> e <paramref name="b"/> e retorna o resultado.
        /// </summary>
        /// <returns>
        /// O produto de dois doubles.
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Math.Multiply(4.5, 5.4);
        /// if (c > 100.0)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// Ver <see cref="Math.Multiply(int, int)"/> para multiplicar integrantes.
        /// <seealso cref="Math.Add(double, double)"/>
        /// <seealso cref="Math.Subtract(double, double)"/>
        /// <seealso cref="Math.Divide(double, double)"/>
        /// <param name="a">Um número de precisão dupla</param>
        /// <param name="b">Um número de precisão dupla</param>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide o integrante por outro e retorna o resultado
        /// <summary>
        /// Divide o integrante <paramref name="a"/> por outro integrante <paramref name="b"/> e returna o resultado
        /// </summary>
        /// <returns>
        /// O quociente de dois integrantes.
        /// </returns>
        /// <example>
        /// <code>
        /// int c = Math.Divide(4, 5);
        /// if (c > 1)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.DivideByZeroException">Joga quando <paramref name="b"/> è igual á zero.</exception>
        /// Ver <see cref="Math.Divide(double, double)"/> Para dividir doubles.
        /// <seealso cref="Math.Add(int, int)"/>
        /// <seealso cref="Math.Subtract(int, int)"/>
        /// <seealso cref="Math.Multiply(int, int)"/>
        /// <param name="a">Um integrante dividendo</param>
        /// <param name="b">Um integrante divisor</param>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        // Divide o integrante por outro e retorna o resultado
        /// <summary>
        /// Divide o integrante <paramref name="a"/> por outro double <paramref name="b"/> e retorna o resultado.
        /// </summary>
        /// <returns>
        /// O quociente de dois doubles.
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Math.Divide(4.5, 5.4);
        /// if (c > 1.0)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.DivideByZeroException">Jogar quando <paramref name="b"/> é igual á zero</exception>
        /// Ver <see cref="Math.Divide(int, int)"/> Para dividir integrantes.
        /// <seealso cref="Math.Add(double, double)"/>
        /// <seealso cref="Math.Subtract(double, double)"/>
        /// <seealso cref="Math.Multiply(double, double)"/>
        /// <param name="a">Um dividendo de precisão dupla.</param>
        /// <param name="b">Um divisor de precisão dupla</param>
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
