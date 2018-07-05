﻿using System;
using Dodo.Core.Common;
using Dodo.Core.DomainModel.Departments;
using Dodo.Core.DomainModel.Departments.Units;

namespace Dodo.Core.UnitTests.DSL
{
    public class ObjectMother
    {
        public Pizzeria CreatePizzeriaWithBeginDateTimeWork(DateTime? beginDateTimeWork)
        {
            return new Pizzeria(
                id: 29,
                uuid: new Uuid("000D3A240C719A8711E68ABA13F83227"),
                name: "Сык-1",
                alias: string.Empty,
                translitAlias: string.Empty,
                approve: UnitApprove.Approved,
                state: UnitState.Open,
                departmentId: 2,
                departmentUuid: new Uuid("000D3A240C719A8711E68ABA13FC4A39"),
                countryId: 1,
                organization: null,
                square: 100,
                beginDateTimeWork: beginDateTimeWork,
                orientation: string.Empty,
                cardPaymentPickup: null,
                coordinateX: null,
                coordinateY: null,
                clientTreatment: ClientTreatment.Name,
                terminalAtCourier: true,
                pizzeriaFormat: null
            );
        }
    }
}