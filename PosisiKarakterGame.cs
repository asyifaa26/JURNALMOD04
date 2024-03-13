using System.Runtime.CompilerServices;
using System.Transactions;

public enum state
{
    Jongkok, 
    Berdiri,
    Tengkurap,
    Terbang,
}

public enum tombol
{
    TombolW,
    TombolS,
    TombolX,
}

public class PosisiKarakterGame
{
    public enum state
    {
        Jongkok,
        Berdiri,
        Tengkurap,
        Terbang,
    }

    public enum tombol
    {
        TombolW,
        TombolS,
        TombolX,
    }
    public class Transition
    {
        public state stateAwal;
        public state stateAkhir;
        public tombol Tombol;

        public Transition(state stateAwal, state stateAkhir, tombol Tombol)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.Tombol = Tombol;   
        } 
    }

    Transition[] transisi =
    {
        new Transition(state.Jongkok, state.Tengkurap, tombol.TombolS),
        new Transition(state.Tengkurap, state.Jongkok, tombol.TombolW),
        new Transition(state.Jongkok, state.Berdiri, tombol.TombolW),
        new Transition(state.Berdiri, state.Terbang, tombol.TombolW),
        new Transition(state.Terbang, state.Berdiri, tombol.TombolS),
        new Transition(state.Terbang, state.Berdiri, tombol.TombolS),
        new Transition(state.Terbang, state.Jongkok, tombol.TombolX),
    };

    public state GetNextState(state stateAwal, tombol Tombol)
    {
        state stateAkhir = stateAwal;
        for (int i = 0; i < transisi.Length; i++)
        {
            Transition change = transisi[i];
            if (stateAwal == change.stateAwal && Tombol == change.Tombol)
            {
                stateAkhir = change.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public state currentState = state.Berdiri;

    public void doActive(tombol Tombol)
    {
        if (Tombol == tombol.TombolW)
        {
            Console.WriteLine("Tombol Arah Atas Ditekan");
        } else if (Tombol == tombol.TombolS)
        {
            Console.WriteLine("Tombol Arah Bawah Ditekan");
        }
        currentState = GetNextState(currentState, Tombol);
        Console.WriteLine("Posisi Anda Sekarang Adalah: " + currentState);
    }
}
