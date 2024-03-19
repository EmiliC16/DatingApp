import { photo } from "./photo";

export interface Member {
  id: number;
  userName: string;
  age:number;
  dateOfBirth: string;
  knownAs: string;
  created: string;
  lastActive: string;
  gender: string;
  introduction: string;
  lookingFor: string;
  interests: string;
  city: string;
  country: string;
  photoUrl: string;
  photos: photo[];
}


