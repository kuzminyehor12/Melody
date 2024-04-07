import { Autocomplete, TextField } from "@mui/material";

export interface Option {
    text: string;
    value: string;
}
  
interface MultiSelectProps {
    options: Option[];
    onChange: (event: React.ChangeEvent<{}>, selectedOptions: Option[]) => void;
    value: Option[];
    label: string;
}

const MultiSelect: React.FunctionComponent<MultiSelectProps> = ({ options, onChange, value, label }) => {
    return (
      <Autocomplete
        style={{ marginTop: '12px' }}
        multiple
        options={options}
        value={value}
        onChange={onChange}
        getOptionLabel={(option) => option.text}
        renderInput={(params) => (
          <TextField
            {...params}
            variant="outlined"
            label={label}
          />
        )}
      />
    );
  };

export default MultiSelect;