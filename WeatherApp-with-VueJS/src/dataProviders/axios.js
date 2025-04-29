import axios from 'axios';
import { baseUrl } from '../constants/appConstants';

export const axiosInstance = axios.create({
  baseURL: baseUrl
});
