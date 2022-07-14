﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrdersAssignmentAPI.Common.DTOs;

namespace WorkOrdersAssignmentAPI.BusinessLogic.Interfaces
{
    public interface IWorkOrders
    {
        Task<IEnumerable<WorkOrderResponse>> GetWorkOrdersByDate(DateTime date);

        Task<IEnumerable<WorkOrderResponse>> GetWorkOrdersByTechnicianId(string technicianRegNum);

        Task<WorkOrderResponse> CreateWorkOrder(WorkOrderInput newWorkOrder);

        Task DeleteWorkOrderById(string workOrderId);

        Task<WorkOrderResponse> UpdateWorkOrderTechnician(string workOrderId, string technicianRegNum);
    }
}