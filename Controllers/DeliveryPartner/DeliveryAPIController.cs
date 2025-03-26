using Foodie.Models.DeliveryPartner;
using Foodie.Repositories.For_DeliveryPartner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers.DeliveryPartner
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryAPIController : ControllerBase
    {
        private readonly IGenericRepository<tbl_deliveryPartners> _partnerrepo;
        private readonly IGenericRepository<tbl_deliveryPartnerDetails> _partnerdetailsrepo;
        private readonly IGenericRepository<tbl_deliveryEarnings> _earningsrepo;
        private readonly IGenericRepository<tbl_wallet> _walletrepo;
        private readonly IGenericRepository<tbl_deliveryVehicle> _vehiclerepo;
        private readonly IGenericRepository<tbl_deliveryRequest> _requestrepo;
        private readonly IGenericRepository<tbl_deliveryNotification> _notificationrepo;
        private readonly IGenericRepository<tbl_deliveryPayouts> _payoutsrepo;
        private readonly IGenericRepository<tbl_deliveryRatings> _ratingsrepo;
        private readonly IGenericRepository<tbl_deliverySlots> _slotsrepo;
        private readonly IGenericRepository<tbl_deliveryTracking> _trackingrepo;
        private readonly IGenericRepository<tbl_partnerPerformance> _perfomarmancerepo;
        private readonly IGenericRepository<tbl_partnerSchedule> _schedulerepo;
        private readonly IGenericRepository<tbl_rejectReason> _reasonrepo;
        private readonly IGenericRepository<tbl_deliveryPartnerPaymentDetails> _paymentsrepo;


        public DeliveryAPIController(IGenericRepository<tbl_deliveryPartners> partnerrepo, IGenericRepository<tbl_deliveryPartnerDetails> partnerdetailsrepo, 
            IGenericRepository<tbl_deliveryEarnings> earningsrepo, IGenericRepository<tbl_wallet> walletrepo, IGenericRepository<tbl_deliveryVehicle> vehiclerepo, 
            IGenericRepository<tbl_deliveryRequest> requestrepo, IGenericRepository<tbl_deliveryNotification> notificationrepo, IGenericRepository<tbl_deliveryPayouts> payoutsrepo, 
            IGenericRepository<tbl_deliveryRatings> ratingsrepo, IGenericRepository<tbl_deliverySlots> slotsrepo, IGenericRepository<tbl_deliveryTracking> trackingrepo, 
            IGenericRepository<tbl_partnerPerformance> perfomarmancerepo, IGenericRepository<tbl_partnerSchedule> schedulerepo, IGenericRepository<tbl_rejectReason> reasonrepo, 
            IGenericRepository<tbl_deliveryPartnerPaymentDetails> paymentsrepo)
        {
            _partnerrepo = partnerrepo;
            _partnerdetailsrepo = partnerdetailsrepo;
            _earningsrepo = earningsrepo;
            _walletrepo = walletrepo;
            _vehiclerepo = vehiclerepo;
            _requestrepo = requestrepo;
            _notificationrepo = notificationrepo;
            _payoutsrepo = payoutsrepo;
            _ratingsrepo = ratingsrepo;
            _slotsrepo = slotsrepo;
            _trackingrepo = trackingrepo;
            _perfomarmancerepo = perfomarmancerepo;
            _schedulerepo = schedulerepo;
            _reasonrepo = reasonrepo;
            _paymentsrepo = paymentsrepo;
        }


        [HttpPost("DISP")]
        public IActionResult Post(tbl_deliveryPartners partner)
        {
            _partnerrepo.Add(partner);
            return Ok();
        }

    }
}
