export class ParticipantsDto {
  count: number | undefined
  participants: ParticipantList[] | undefined
}

export class ParticipantList {
  id: String | undefined;
  logoUri: String | undefined;
  name: String | undefined;
}
