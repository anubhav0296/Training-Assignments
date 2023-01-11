using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    public class Team: IEnumerable
    {
        public Player[] players;

        public Team(Player[] playerArray)
        {
            players = new Player[playerArray.Length];
            for (int i=0; i<playerArray.Length; i++)
            {
                players[i] = playerArray[i];
            }
        }


        //Get enumerator method implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(players);
        }
    }

    //implementation of IEnumerator
    public class TeamEnum: IEnumerator
    {
        public Player[] players;
        public int pos = -1;

        public TeamEnum(Player[] p)
        {
            players = p;
        }
        public bool MoveNext()
        {
            pos++;
            return (pos < players.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Player Current
        {
            get
            {
                try
                {
                    return players[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
