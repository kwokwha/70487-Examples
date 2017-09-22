﻿using System.ServiceModel;

namespace ConcurrentServices.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                     ConcurrencyMode = ConcurrencyMode.Multiple,
                     UseSynchronizationContext = true)]
    public class PerSession_Multi_Service : BaseService
    {
    }
}
