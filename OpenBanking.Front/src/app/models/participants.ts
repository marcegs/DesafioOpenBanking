export class Participants {
  count: number | undefined;
  participants: ParticipantList[] | undefined;
}

export class ParticipantList {
  id: String | undefined;
  name: String | undefined;
  active: boolean = false;
}
