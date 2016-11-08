using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

[Route("/api/bandb")]
public class BandBController : CRUDController<Models.BandB> {
    public BandBController(IRepository<Models.BandB> r) : base(r){}
}

// [Route("/api/cardlist")]
// public class CardListController : CRUDController<CardList> {
//     public CardListController(IRepository<CardList> r) : base(r){}
// }

// [Route("/api/board")]
// public class BoardController : CRUDController<Board> {
//     public BoardController(IRepository<Board> r) : base(r){}
// }
