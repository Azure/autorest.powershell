import { Class } from './class';
import { Interface } from './interface';
import { Property } from './property';

export interface TypeContainer {
  addClass(c: Class): Class;

  addInterface(c: Interface): Interface;
  fullName: string;
}

export interface IInterface {
  allProperties: Array<Property>
  fullName: string;
}