import { photo } from "./photo";

export interface Member {
  id: number;
  UserName: string;
  gender: string;
  age:number;
  dateOfBirth: string;
  knownAs: string;
  created: string;
  lastActive: string;
  introduction: string;
  lookingFor: string;
  interests: string;
  city: string;
  country: string;
  photoUrl: string;
  photos: photo[];
}


