import '@babel/polyfill';
// eslint-disable-next-line no-unused-vars
import React, { ChangeEvent } from 'react';
import {
  Grid, TextField, Button, FormControl,
  Input, FormHelperText,
} from '@material-ui/core';
import PublishIcon from '@material-ui/icons/Publish';
// eslint-disable-next-line no-unused-vars
import { WithTranslation, useTranslation } from 'react-i18next';
// eslint-disable-next-line no-unused-vars
import { withSnackbar, WithSnackbarProps } from 'notistack';
// eslint-disable-next-line no-unused-vars
import { FormikProps } from 'formik';
// eslint-disable-next-line no-unused-vars
import { IStaticImageForm } from '../../../../../../TypeScript/Interfaces/IStaticImageForm';
import Createdby from '../../../Created/Created';
import useStyles from '../../../../Utils/Form.Styles';
import NoImage from '../../NoImage';
import ImageInfo from '../../ImageInfo';

export type IForm = FormikProps<IStaticImageForm> & WithTranslation & WithSnackbarProps;

export default (props: IForm): React.ReactElement<IForm> => {
  const classes = useStyles({});
  const { t, i18n } = useTranslation('StaticImageForm');

  const {
    enqueueSnackbar,
    values,
    touched,
    errors,
    isSubmitting,
    handleChange,
    handleBlur,
    handleSubmit,
    setFieldTouched,
    setFieldValue,
  } = props;

  const myRef = React.useRef<HTMLInputElement>(null);

  const pickFile = (): void => {
    if (myRef.current) {
      myRef.current.click();
    }
  };

  const changeFile = (event: ChangeEvent<HTMLInputElement>): void => {
    if (event.target.files?.length === 0) {
      enqueueSnackbar('No image', {
        variant: 'error',
      });
      return;
    }

    // @ts-ignore: Object is possibly 'null'.
    const myFile = event.target.files[0];

    const reader = new FileReader();
    reader.readAsDataURL(myFile);
    reader.onload = (): void => {
      const { result } = reader;

      setFieldValue('Data', result);
      setFieldValue('Src', result);

      const myImage = new Image();
      // @ts-ignore: Object is possibly 'null'.
      myImage.src = result.toString();
      myImage.onload = (): void => {
        setFieldValue('Size', myFile.size);
        setFieldValue('Mime', myFile.type);
        setFieldValue('Width', myImage.width);
        setFieldValue('Height', myImage.height);
      };
    };
    reader.onerror = (err): void => {
      enqueueSnackbar(`error: ${err}`, {
        variant: 'error',
      });

      // eslint-disable-next-line no-console
      console.log('err', err);
    };
  };

  i18n.on('languageChanged', (): void => {
    Object.keys(errors).forEach((fieldName): void => {
      setFieldTouched(fieldName as any);
    });
  });

  return (
    <form
      className={classes.root}
      autoComplete="off"
      onSubmit={handleSubmit}
    >
      <Grid
        container
        spacing={2}
        justify="center"
        alignItems="center"
      >
        <Grid
          item
          xs={12}
          md={12}
          lg={6}
        >
          <TextField
            margin="dense"
            error={errors.Text_PT as any && touched.Text_PT as any}
            label={t('StaticImageForm:textPT.text')}
            title={t('StaticImageForm:textPT.title')}
            name="Text_PT"
            id="Text_PT"
            value={values.Text_PT}
            onChange={handleChange}
            onBlur={handleBlur}
            helperText={(errors.Text_PT && touched.Text_PT) && errors.Text_PT}
            variant="outlined"
            multiline
            rows={3}
            rowsMax={6}
            className={classes.item}
            fullWidth
          />
        </Grid>
        <Grid
          item
          xs={12}
          md={12}
          lg={6}
        >
          <TextField
            margin="dense"
            error={errors.Text_ENG as any && touched.Text_ENG as any}
            label={t('StaticImageForm:textENG.text')}
            title={t('StaticImageForm:textENG.title')}
            name="Text_ENG"
            id="Text_ENG"
            value={values.Text_ENG}
            onChange={handleChange}
            onBlur={handleBlur}
            helperText={(errors.Text_ENG && touched.Text_ENG) && errors.Text_ENG}
            variant="outlined"
            multiline
            rows={3}
            rowsMax={6}
            className={classes.item}
            fullWidth
          />
        </Grid>
        <Grid
          item
          xs={12}
          md={12}
          lg={12}
        >
          <FormControl>
            <Input
              id="image-file"
              value={values.Src}
              className={classes.hidden}
              inputComponent={(): React.ReactElement => (
                <input
                  ref={myRef}
                  type="file"
                  id="image-file"
                  accept="image/png"
                  onChange={changeFile}
                />
              )}
            />
            <FormHelperText
              error
              id="image-helper-text"
            >
              {errors.Src && touched.Src && errors.Src}
            </FormHelperText>
          </FormControl>
          {
            (values.Data === '' || undefined)
              ? <NoImage alt="No image" />
              : (
                <ImageInfo
                  Src={values.Data || ''}
                  Alt="Imagem a ser enviada ao servidor"
                  Mime={values.Mime}
                  Size={values.Size}
                  Width={values.Width}
                  Height={values.Height}
                />
              )
          }
          <Button
            color="primary"
            variant="outlined"
            startIcon={<PublishIcon />}
            onClick={pickFile}
          >
            {t('StaticImageForm:file.title')}
          </Button>
        </Grid>
        <Grid
          item
          xs={12}
          md={12}
          lg={12}
        >
          <Createdby Created={values.Created} CreatedBy={values.CreatedBy} />
        </Grid>
        <Grid
          item
          xs={12}
          md={12}
          lg={12}
        >
          <Button
            className={classes.button}
            color="primary"
            variant="contained"
            type="submit"
            title={t('StaticImageForm:button.title')}
            disabled={isSubmitting}
          >
            {t('StaticImageForm:button.text')}
          </Button>
        </Grid>
      </Grid>
    </form>
  );
};
