using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardSystem
{
    public interface IDeck
    {
        List<ICard> CardList { get; }

    }
}
