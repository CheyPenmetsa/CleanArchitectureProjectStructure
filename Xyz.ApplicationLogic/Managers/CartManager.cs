using Xyz.ApplicationLogic.Interfaces;
using Xyz.Core.Interfaces;
using Xyz.Core.Repositories;

namespace Xyz.ApplicationLogic.Managers
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICoreLogger _logger;
        private readonly IEmailSender _emailSender;

        public CartManager(ICartRepository cartRepository,
            ICoreLogger logger,
            IEmailSender emailSender)
        {
            _cartRepository = cartRepository;
            _logger = logger;
            _emailSender = emailSender;
        }

        public async Task AddItem(string userName, int productId)
        {
            //Get the cart using _cartRepository
            //Add product to cart
            //Save cart using _cartRepository
            //Send email using _emailSender
        }

    }
}
