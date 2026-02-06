import axios, { AxiosInstance } from 'axios';
import { baseUrl } from '@/constants/appConstants';

export const axiosInstance: AxiosInstance = axios.create({
  baseURL: baseUrl
});