// eslint-disable-next-line no-unused-vars
import { ILanguage } from './ILanguage';

export default {
  title: 'Static data from the first page of the report',
  textPT: {
    text: 'Description in Portuguese',
    title: 'The text of the description in Portuguese',
    required: 'This field is required',
    min: '5 character minimum',
    max: '3000 characters maximum',
  },
  textENG: {
    text: 'Description in English',
    title: 'The text of the description in English',
    required: 'This field is required',
    min: '5 character minimum',
    max: '3000 characters maximum',
  },
  button: {
    text: 'Save changes',
    title: 'Click here to save changes',
  },
  created: {
    name: 'Last changes by',
    date: 'in',
  },
  feedback: {
    success: 'Successfully saved your data',
    failure: 'Sorry but no data was saved',
  },
  attachment: {
    uploads: 'Uploads',
    save: 'Save',
    dropzoneText: 'Drag and drop up one file JPEG or PNG files (up to 300kb each) here or click',
    noAttachments: 'No attachments yet!',
  },
} as ILanguage;